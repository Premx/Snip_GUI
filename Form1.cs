using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snip_GUI
{
    public partial class Form1 : Form
    {
        SortableBindingList<Line> dInstance;
        Dictionary<String,int>[] cachedic;
        int keymode = 0;
        int threads = 1;
        public Form1()
        {
            InitializeComponent();
            Parser.Instance.form1instance = this;
            dataGridView1.AutoGenerateColumns = true;
        }

        private void labelprgress_Clic(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dInstance = null;
                cachedic = null;
                dataGridView1.DataSource = null;
                dataGridView1.Update();
                GC.Collect();

                threads = int.Parse(toolStripTextBox1.Text);
                Parser.logfileName = openFileDialog1.FileName;
                String[] keys = new String[0];
                if (listBox1.Items.Count > 0) {
                    keys = new String[listBox1.Items.Count];

                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        keys[i] = (String)listBox1.Items[i];
                    }
                }

                Parser.Instance.start(keys,keymode,threads);

            }

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TODO Text input dialog
            String key2Add = Prompt.ShowDialog("Enter keyword: ", "Enter keyword");
            listBox1.Items.Add(key2Add);
        }

        private void buttonDelKey_Click(object sender, EventArgs e)
        {
            //TODO Text input dialog
            listBox1.Items.Remove(listBox1.SelectedItem);
            
        }

        public void setLabelProgresstext(String text)
        {

            if (this.labelProgress.InvokeRequired)
            {
                SetTextCallback s = new SetTextCallback(setLabelProgresstext);
                this.Invoke(s,new object[] { text });
            }
            else
            {
                this.labelProgress.Text = text;
            }

        }

        public void setLabelStatustext(String text)
        {
            if (this.labelStatus.InvokeRequired)
            {
                SetTextCallback s = new SetTextCallback(setLabelStatustext);
                this.Invoke(s, new object[] { text });
            }
            else
            {
                this.labelStatus.Text = text;
            }
        }

        public void setGridDataView(object obj, Dictionary<String,int>[] cachedic)
        {
            dInstance = null;
            this.cachedic = null;

            GC.Collect();

            dInstance = (SortableBindingList<Line>)obj;
            this.cachedic =cachedic;
            if (this.dataGridView1.InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate 
                {
                   
                    dataGridView1.DataSource = obj;
                    /*
                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {

                        column.SortMode = DataGridViewColumnSortMode.Automatic;
                    }
                    */
                    
                    dataGridView1.Update();

                });
            }
            else
            {
                
            }
        }

        delegate void SetDataSourceCallback(Object obj);

        delegate void SetTextCallback(String text);

        

        private void browserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PieBootstrap pb = new PieBootstrap(dInstance);
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            keymode = 1;

            

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            keymode = 0;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String s = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                Console.WriteLine("Row:{0} Column:{1}\nValue{2}", e.RowIndex, e.ColumnIndex, s);
                labelStatus.Text = cachedic[e.ColumnIndex][s].ToString() + " Entries";
            }
            catch 
            {
                labelStatus.Text = "/ Entries";
            }
           
        }

        private void sortByHostnameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sort(0);
           
        }

        private void sort(int index)
        {
            this.dataGridView1.Sort(this.dataGridView1.Columns[index], ListSortDirection.Descending);
        }

        private void sortByDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sort(1);
        }

        private void sortByRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sort(2);
        }

        private void sortByHTTPCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sort(3);
        }

        private void sortByBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sort(5);
        }

        private void sortByAgentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sort(6);
        }

        
    }

}
