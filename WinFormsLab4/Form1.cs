using LAB4;

namespace WinFormsLab4
{
    public partial class Form1 : Form
    {
        private SQLiteHandler dbHandler = new SQLiteHandler();
        private bool isConnected = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void databseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dbHandler.ConnectToDb();
                isConnected = true;

                MessageBox.Show(
                    "Successfully connected to the database!",
                    "Database",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Database connection failed: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dbHandler.DisconnectFromDb();
                isConnected = false;

                MessageBox.Show(
                    "Disconnected from the database.",
                    "Database",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Disconnection failed: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void addKeywordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                MessageBox.Show(
                    "Please connect to the database first.",
                    "Database",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            using (Form2 inputForm = new Form2())
            {
                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    string keyword = inputForm.GetInputText();

                    if (!string.IsNullOrWhiteSpace(keyword))
                    {
                        try
                        {
                            dbHandler.InsertKeyword(keyword);

                            MessageBox.Show(
                                "Keyword added successfully!",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(
                                "Error adding keyword: " + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                            "Please enter a keyword.",
                            "Warning",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                    }
                }
            }
        }

        private void viewKeywordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                MessageBox.Show(
                    "Please connect to the database first.",
                    "Database",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            try
            {
                List<string> keywords = dbHandler.GetAllKeywords();

                if (keywords.Count == 0)
                {
                    MessageBox.Show(
                        "No keywords found in the database.",
                        "Keywords",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    return;
                }

                string result = string.Join(Environment.NewLine, keywords);

                MessageBox.Show(
                    result,
                    "Stored Keywords",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error retrieving keywords: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "LAB4 - SQLite Database Application\n\n" +
                "This application allows you to connect to an SQLite database, " +
                "add keywords and view stored keywords.",
                "About",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void deleteKeywordsToolStripMenuItem_Click(
    object sender,
    EventArgs e)
        {
            if (!isConnected)
            {
                MessageBox.Show(
                    "Please connect to the database first.",
                    "Database",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete all keywords?",
                "Confirm deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    dbHandler.DeleteAllKeywords();

                    MessageBox.Show(
                        "All keywords have been deleted.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error deleting keywords: " + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }
    }
}
