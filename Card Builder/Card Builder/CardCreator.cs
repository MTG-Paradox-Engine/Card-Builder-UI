using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace Card_Builder
{
    public partial class CardCreator : Form
    {
        Card card = new Card();
        public CardCreator()
        {
            InitializeComponent();
            if (CB_Power.Items.Count > 0) { CB_Power.SelectedItem = CB_Power.Items[1]; }
            if (CB_Toughness.Items.Count > 0) { CB_Toughness.SelectedItem = CB_Toughness.Items[1]; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string output = JsonConvert.SerializeObject(card);
            TextWriter txt = new StreamWriter(card.name+".json");
            txt.Write(output);
            txt.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            card.name = TB_NAME.Text;
        }

        private void B_ADD_Click(object sender, EventArgs e)
        {
            card.Colors.Add(LB_colors.SelectedItem.ToString());
            LB_Selc_Colors.DataSource = null;
            LB_Selc_Colors.DataSource = card.Colors.ToList();
        }

        private void B_REMOVE_Click(object sender, EventArgs e)
        {
            if (LB_Selc_Colors.SelectedItem == null)
                return;
            card.Colors.Remove(LB_Selc_Colors.SelectedItem.ToString());
            LB_Selc_Colors.DataSource = null;
            LB_Selc_Colors.DataSource = card.Colors.ToList();
        }

        private void B_Add_Type_Click(object sender, EventArgs e)
        {
            card.SuperType.Add(TB_Type.Text);
            LB_Type.DataSource = null;
            LB_Type.DataSource = card.SuperType.ToList();
        }

        private void B_Remove_Type_Click(object sender, EventArgs e)
        {
            if (LB_Type.SelectedItem == null)
                return;
            card.SuperType.Remove(LB_Type.SelectedItem.ToString());
            LB_Type.DataSource = null;
            LB_Type.DataSource = card.SuperType.ToList();
        }

        private void B_Add_Sub_Click(object sender, EventArgs e)
        {
            card.SubType.Add(TB_Subtype.Text);
            LB_Sub.DataSource = null;
            LB_Sub.DataSource = card.SubType.ToList();

        }

        private void B_Remove_Sub_Click(object sender, EventArgs e)
        {
            if (LB_Sub.SelectedItem == null)
                return;
            card.SubType.Remove(LB_Sub.SelectedItem.ToString());
            LB_Sub.DataSource = null;
            LB_Sub.DataSource = card.SubType.ToList();

        }
        private void CB_Power_SelectedIndexChanged(object sender, EventArgs e)
        {
            card.power = CB_Power.Text;
        }

        private void CB_Toughness_SelectedIndexChanged(object sender, EventArgs e)
        {
            card.Toughness = CB_Toughness.Text;
        }

        private void Import_Button_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Read the contents of the file into a stream
                var fileStream = openFileDialog.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    card = JsonConvert.DeserializeObject<Card>(reader.ReadToEnd());

                    LB_Sub.DataSource = null;
                    LB_Sub.DataSource = card.SubType.ToList();
                    LB_Type.DataSource = null;
                    LB_Type.DataSource = card.SuperType.ToList();
                    LB_Selc_Colors.DataSource = null;
                    LB_Selc_Colors.DataSource = card.Colors.ToList();
                    TB_NAME.Text = card.name;
                    CB_Power.Text  = card.power;
                    CB_Toughness.Text  = card.Toughness;
                }
            }
        }


    }
}
