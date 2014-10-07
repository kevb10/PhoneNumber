/* UserInterface.cs
 * Author: Kevin Manase
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ksu.Cis300.MatchCalls
{
    public partial class UserInterface : Form
    {
        /// <summary>
        /// File 1
        /// </summary>
        private LinkedListCell<PhoneCount> _file1 = new LinkedListCell<PhoneCount>();

        /// <summary>
        /// File 2
        /// </summary>
        private LinkedListCell<PhoneCount> _file2 = new LinkedListCell<PhoneCount>();

        public UserInterface()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load file 1 and put its content into _file1
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="e">Event argument</param>
        private void uxLoadFile1_Click(object sender, EventArgs e)
        {
            if (uxOpenDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _file1 = ReadFile(uxOpenDialog.FileName);
                    uxFile1Status.Text = "File 1 loaded.";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errors:" + ex);
                }

            }
        }

        /// <summary>
        /// Load file 2 and put its content into _file2
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="e">Event argument</param>
        private void uxLoadFile2_Click(object sender, EventArgs e)
        {
            if (uxOpenDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _file2 = ReadFile(uxOpenDialog.FileName);
                    uxFile2Status.Text = "File 2 loaded.";
                    if (uxFile1Status.Text != "No file loaded." && uxFile2Status.Text != "No file loaded.")
                    {
                        uxFind.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errors:" + ex);
                }
                
            }
        }

        /// <summary>
        /// Read the selected file and parse it into a LinkedListCell
        /// </summary>
        /// <param name="s">The path of the file</param>
        /// <returns>returns a ListLinkedCell</returns>
        private LinkedListCell<PhoneCount> ReadFile(string s)
        {
            LinkedListCell<PhoneCount> cell = new LinkedListCell<PhoneCount>();

            using (StreamReader input = new StreamReader(uxOpenDialog.FileName))
            {
                while (!input.EndOfStream)
                {
                    string num = input.ReadLine().Trim();

                    if (cell == null)
                    {
                        PhoneCount phone = new PhoneCount(num, 1);
                        LinkedListCell<PhoneCount> newCell = new LinkedListCell<PhoneCount>();
                        newCell.Data = phone;
                        newCell.Next = cell;
                        cell = newCell;
                    }
                    else if (CheckIt(cell, num) == true)
                    {
                        continue;
                    }
                    else
                    {
                        PhoneCount phone = new PhoneCount(num, 1);
                        LinkedListCell<PhoneCount> newCell = new LinkedListCell<PhoneCount>();
                        newCell.Data = phone;
                        newCell.Next = cell;
                        cell = newCell;
                    }

                }
            }
            return cell;
        }


        /// <summary>
        /// Sets default values on program load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserInterface_Load(object sender, EventArgs e)
        {
            uxFile1Status.Text = "No file loaded.";
            uxFile2Status.Text = "No file loaded.";
            uxFind.Enabled = false;
            uxValue.Value = 5;
        }

        /// <summary>
        /// Finds overlaps on clicked
        /// </summary>
        /// <param name="sender">Object sender</param>
        /// <param name="e">Event Argument</param>
        private void uxFind_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            for (LinkedListCell<PhoneCount> cellA = _file1; cellA.Next != null; cellA = cellA.Next )
            {
                if (cellA.Data.Count >= uxValue.Value)
                {
                    for (LinkedListCell<PhoneCount> cellB = _file2; cellB.Next != null; cellB = cellB.Next)
                    {
                        if (cellA.Data.PhoneNumber == cellB.Data.PhoneNumber && cellB.Data.Count >= uxValue.Value)
                        {
                            sb.Append(cellA.Data.PhoneNumber + "\r\n");
                            sb.Append("\t" + cellA.Data.Count + " times (file 1) \r\n");
                            sb.Append("\t" + cellB.Data.Count + " times (file 2) \r\n");
                            sb.Append("\r\n");
                        }
                        else
                            continue;
                    }
                }
                else
                    continue;
            }

            if (sb.Length == 0)
            {
                uxTextBox.Text = "No matches found.";
            }

            uxTextBox.Text = sb.ToString();
        }

        /// <summary>
        /// Checks if there is a number in the cell already
        /// </summary>
        /// <param name="lc">LinkedListCell to check</param>
        /// <param name="s">String to check against</param>
        /// <returns>if matches then true</returns>
        public bool CheckIt(LinkedListCell<PhoneCount> lc, string s)
        {
            while (lc.Next != null)
            {
                if (lc.Data.PhoneNumber == s)
                {
                    lc.Data.Count++;
                    return true;
                }
                else
                {
                    lc = lc.Next;

                }
            }
            return false;
        }


    }
}
