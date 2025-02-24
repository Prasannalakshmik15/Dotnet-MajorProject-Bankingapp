using System.Data.SqlClient;



namespace BankingAppCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtAdd.Text) || string.IsNullOrEmpty(txtBalance.Text))
            {
                MessageBox.Show("Please fill all the fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtBalance.Text, out int depositAmount) || depositAmount <= 0)
            {
                MessageBox.Show("Please enter a valid positive number for balance.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Establishing connection
            using (SqlConnection con = new SqlConnection("Data Source=Prasanna;Initial Catalog=bankingappli;Integrated Security=True;TrustServerCertificate=True"))
            {
                con.Open();
                string depositQuery = "INSERT INTO account1 (name, address, balance, accountno, date, deposit) " +
                                      "VALUES (@name, @add, @balance, @acc, @date, @deposit)";

                using (SqlCommand cmd = new SqlCommand(depositQuery, con))
                {
                    // Generating unique account number
                    string accountno = AccountNo();

                    // Adding parameters
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@add", txtAdd.Text);
                    cmd.Parameters.AddWithValue("@balance", depositAmount);
                    cmd.Parameters.AddWithValue("@date", dtDate.Value);
                    cmd.Parameters.AddWithValue("@deposit", depositAmount);
                    cmd.Parameters.AddWithValue("@acc", accountno);

                    int count = cmd.ExecuteNonQuery();

                    if (count > 0)
                    {
                        MessageBox.Show("Deposited successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Optionally, clear input fields after successful deposit
                        txtName.Clear();
                        txtAdd.Clear();
                        txtBalance.Clear();
                        dtDate.Value = DateTime.Now;
                    }
                    else
                    {
                        MessageBox.Show("Deposit failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private string AccountNo()
        {
            string startWith = "1280";
            Random random = new Random();
            string gen = random.Next(0, 999999).ToString("D6");
            string accountNo = startWith + gen;
            return accountNo;


        }

        private void btnWithd_Click(object sender, EventArgs e)
        {
            int balance = 0;

            // Input validation
            if (string.IsNullOrWhiteSpace(txtAcc.Text) || string.IsNullOrWhiteSpace(txtBalance.Text))
            {
                MessageBox.Show("Please enter account number and withdrawal amount.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if withdrawal amount is a valid positive integer
            if (!int.TryParse(txtBalance.Text, out int withdrawAmount) || withdrawAmount <= 0)
            {
                MessageBox.Show("Please enter a valid positive number for withdrawal.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection con = new SqlConnection("Data Source=Prasanna;Initial Catalog=bankingappli;Integrated Security=True;TrustServerCertificate=True"))
            {
                con.Open();

                // Corrected query to count rows with matching account number
                string readQuery = "SELECT COUNT(*) FROM account1 WHERE accountno=@acc";
                using (SqlCommand cmd = new SqlCommand(readQuery, con))
                {
                    cmd.Parameters.AddWithValue("@acc", txtAcc.Text);

                    // Corrected conversion to handle null
                    int count = Convert.ToInt32(cmd.ExecuteScalar() ?? 0);

                    if (count > 0)
                    {
                        // Get the current balance
                        string balanceQuery = "SELECT balance FROM account1 WHERE accountno=@acc";
                        using (SqlCommand balanceCmd = new SqlCommand(balanceQuery, con))
                        {
                            balanceCmd.Parameters.AddWithValue("@acc", txtAcc.Text);
                            object result = balanceCmd.ExecuteScalar();
                            balance = Convert.ToInt32(result ?? 0);
                        }

                        if (balance > 0 && balance >= withdrawAmount)
                        {
                            int newBalance = balance - withdrawAmount;

                            // Update balance and record withdrawal
                            string updateQuery = "UPDATE account1 SET balance=@balance, withdraw=@with WHERE accountno=@accno";
                            using (SqlCommand cmdup = new SqlCommand(updateQuery, con))
                            {
                                cmdup.Parameters.AddWithValue("@balance", newBalance);
                                cmdup.Parameters.AddWithValue("@with", withdrawAmount);
                                cmdup.Parameters.AddWithValue("@accno", txtAcc.Text);
                                cmdup.ExecuteNonQuery();
                            }

                            MessageBox.Show($"Withdrawn successfully! Remaining Balance: {newBalance}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Clear input fields
                            txtAcc.Clear();
                            txtBalance.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Insufficient balance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Account not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }


        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=Prasanna;Initial Catalog=bankingappli;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            string selectQuery = "SELECT * FROM account1 WHERE accountno=@acc";
            SqlCommand cmd = new SqlCommand(selectQuery, con);
            cmd.Parameters.AddWithValue("@acc", txtAcc.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtName.Text = reader["name"].ToString();
                txtAdd.Text = reader["address"].ToString();
                txtBalance.Text = reader["balance"].ToString();
            }
            reader.Close();
            con.Close();
            dtDate.Enabled = false;





            }
    }
}
                


           
