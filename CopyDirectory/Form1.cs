using System;
using System.IO;
using System.Windows.Forms;

namespace CopyDirectory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSource_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtSource.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnDestination_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
            {
                txtDestination.Text = folderBrowserDialog2.SelectedPath;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            try
            {
                string source = @txtSource.Text;
                string destination = @txtDestination.Text;

                //Copy the directory
                DirectoryCopy(source, destination);
                //Add history
                listHistory.Items.Add(string.Format("{0} copied to {1}", source, destination));
                //Show success message
                MessageBox.Show("Directory copied successfully!");
            }
            catch (Exception ex)
            {
                //Show error message
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private static void DirectoryCopy(string sourceDirectory, string destinationDirectory)
        {
            var dir = new DirectoryInfo(sourceDirectory);
            var dirs = dir.GetDirectories();

            //If the source directory does not exist
            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist: "
                    + sourceDirectory);
            }

            //If the destination directory does not exist, create it
            if (!Directory.Exists(destinationDirectory))
            {
                Directory.CreateDirectory(destinationDirectory);
            }


            //Get the file contents of the directory to copy
            var files = dir.GetFiles();

            foreach (var file in files)
            {
                //Create the path to the new copy of the file
                var temppath = Path.Combine(destinationDirectory, file.Name);

                //Copy the file.
                file.CopyTo(temppath, true);
            }

            //Copy the subdirectories
            foreach (var subdir in dirs)
            {
                //Create the subdirectory
                var temppath = Path.Combine(destinationDirectory, subdir.Name);

                //Copy the subdirectories
                DirectoryCopy(subdir.FullName, temppath);
            }
        }
    }
}