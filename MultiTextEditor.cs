//Author: Nimsith & Gaelen
//Project: NETD Project - TextEditor
//Date: April 8th, 2021
//Description: This application is the another budget version of notepad, basic file management services are available

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Group12
{
    public partial class formTextEditor : Form
    {
        //This is the filepath of the active file, if applicable.
        string filepath = string.Empty;
        public formTextEditor()
        {
            InitializeComponent();
        }
        #region "Event Handlers"
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        /// <summary>
        /// THis is used to create a new blank text file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void FileNew(object sender, EventArgs e)
        {
            textBoxEditor.Clear();
            filepath = string.Empty;
            UpdateTitle();
        }

        /// <summary>
        /// Exits the application
        /// </summary>
        public void FileExit(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void FileClose(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// By clicking Open you can select any text file to open.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void FileOpen(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader read = new StreamReader(File.OpenRead(openDialog.FileName));

                textBoxEditor.Text = read.ReadToEnd();
                read.Dispose();

                filepath = openDialog.FileName;

                UpdateTitle();
            }
        }

        /// <summary>
        /// Copying stuff to the clipboard
        /// </summary>
        public void EditCopy(object sender, EventArgs e)
        {
            if(this.MdiChildren.Length > 0)
            {
                if(this.ActiveMdiChild.GetType() == typeof(formTextEditor))
                {
                    formTextEditor textEditorInstance = (formTextEditor)this.ActiveMdiChild;
                    textEditorInstance.EditCopy(sender, e);

                }
                else
                {
                    MessageBox.Show("The copy operation is not supposted by the current selected window.");
                }
            }
        }

        /// <summary>
        /// After copying something to the clipboard you can paste it using this 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditPaste(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                if (this.ActiveMdiChild.GetType() == typeof(formTextEditor))
                {
                    formTextEditor textEditorInstance = (formTextEditor)this.ActiveMdiChild;
                    textEditorInstance.EditPaste(sender, e);

                }
                else
                {
                    MessageBox.Show("The Paste operation is not supposted by the current selected window.");
                }
            }

        }

        /// <summary>
        /// Cutting stuff from the clipboard, which removes text and using the select you can paste them again
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void EditCut(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxEditor.SelectedText);

            textBoxEditor.SelectedText = string.Empty;

        }

        /// <summary>
        /// Saves the work done so far, if its saving for the first time it will tell the user to select a location
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SaveClick(object sender, EventArgs e)
        {
            if (filepath == string.Empty)
            {
                FileSaveAs(sender, e);
            }
            else
            {
                SaveTextFile(filepath);
            }
        }

        /// <summary>
        /// The program will ask the user to select a location to save the file
        /// </summary>
        public void FileSaveAs(object sender, EventArgs e)
        {
            if(this.MdiChildren.Length > 0)
            {
                if (this.ActiveMdiChild.GetType() == typeof(formTextEditor))
                {
                    formTextEditor textEditorInstance = (formTextEditor)this.ActiveMdiChild;
                    textEditorInstance.FileSaveAs(sender, e);

                }

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void windowNewTextEditor(object sender, EventArgs e)
        {
            formTextEditor textEditorInstance = new formTextEditor();
            textEditorInstance.MdiParent = this;
            textEditorInstance.Show();
            textEditorInstance.Focus();
        }


        /// <summary>
        /// Displays a little message about this application in the help dropdown
        /// </summary>
        public void HelpAbout(object sender, EventArgs e)
        {
            MessageBox.Show("Text Editor\n" + "By Gaelen & Nimsith\n\n" + "For NETD 2202 Final Project" +
                "\n" + "April 2021", "About this Application");

        }

        /// <summary>
        /// 
        /// </summary>
        public void ConfirmClose(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("Do you want to save changes to your text?", "My Application",
                 MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                e.Cancel = true;
                FileSaveAs(sender, e);
            }

        }


        #endregion

        #region "Other Functions"
        /// <summary>
        /// Updates the title of the Interface once you save the file
        /// </summary>
        public void UpdateTitle()
        {
            this.Text = "Group 2's Whiteboard";
            if (filepath != string.Empty)
            {
                this.Text += " - " + filepath;
            }
        }

        /// <summary>
        /// Saves the text File created
        /// </summary>
        /// <param name="path"> The path of the writer to </param>
        public void SaveTextFile(string path)
        {
            FileStream myFile = new FileStream(path, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(myFile);

            writer.Write(textBoxEditor.Text);

            writer.Close();
        }
        #endregion

        private void WindowCascade(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        //private void windowTileVertical(object sender, EventArgs e)
        //{
        //   this.LayoutMdi(MdiLayout.TileVertical);
        // }
    }
}
