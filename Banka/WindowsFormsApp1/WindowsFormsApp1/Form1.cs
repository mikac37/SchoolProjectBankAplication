using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public partial class formica : Form
    {
        SqlConnection konekcija = new SqlConnection(Konekcija.konString);


        //D)
        private void Radio()
        {
            string x = "";

            if (radioButton1.Checked)
            {
                x = radioButton1.Text;
            }
            if (radioButton2.Checked)
            {
                x = radioButton2.Text;
            }
            if (radioButton3.Checked)
            {
                x = radioButton3.Text;
            }
            if (radioButton4.Checked)
            {
                x = radioButton4.Text;
            }
            try
            {
                konekcija.Open();

                SqlCommand cmd = new SqlCommand("select count(*)\r\nfrom Racun r join Klijent k\r\non r.IDRacun = k.Racun\r\nwhere r.Tip= @tip", konekcija);
                cmd.Parameters.AddWithValue("tip", x);

                SqlCommand cmd2 = new SqlCommand("select max(stanje) from Racun r join Klijent k\r\non r.IDRacun = k.Racun \r\nwhere r.Tip=  @tip", konekcija);
                cmd2.Parameters.AddWithValue("tip", x);

                boxBrojOtvorenihRacuna.Text = cmd.ExecuteScalar().ToString();
                boxNajviseSredstva.Text = cmd2.ExecuteScalar().ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("GRESKA: " + ex.Message);
            }
            finally
            {
                konekcija.Close();
            }

        }

        public formica()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //C)

            // TODO: This line of code loads data into the 'bankaDataSet.Racun' table. You can move, or remove it, as needed.
            this.racunTableAdapter.Fill(this.bankaDataSet.Racun);
            // TODO: This line of code loads data into the 'bankaDataSet.Klijent' table. You can move, or remove it, as needed.
            this.klijentTableAdapter.Fill(this.bankaDataSet.Klijent);

            //E) 1.
            try
            {
                konekcija.Open();

                SqlCommand cmd = new SqlCommand("select distinct ImePrezime from Klijent", konekcija);
                
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBox1.Items.Add(reader[0].ToString());
                }
                

                

            }
            catch (Exception ex)
            {
                MessageBox.Show("GRESKA: " + ex.Message);
            }
            finally
            {
                konekcija.Close();
            }

        }

        //D)
        private void obradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           grboxRacun.Enabled = true;
        }
        //D)
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Radio();
        }
        //D)
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Radio();
        }
        //D)
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Radio();
        }
        //D)
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Radio();
        }

        //E)
        private void klijentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grBoxKlijenti.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //E) 1.
            listBox1.Items.Clear();
            try
            {
                konekcija.Open();

                SqlCommand cmd = new SqlCommand("select IDKlijent, Stanje\r\nfrom Klijent\r\nwhere ImePrezime = @ime", konekcija);
                cmd.Parameters.AddWithValue("ime", comboBox1.SelectedItem.ToString());

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listBox1.Items.Add(reader[0].ToString() + " " +reader[1].ToString());
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show("GRESKA: " + ex.Message);
            }
            finally
            {
                konekcija.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // E) 2.
            listBox1.Items.Clear();
            if(!string.IsNullOrEmpty(boxStanjeVeceOD.Text)) 
            {
                try
                {
                    konekcija.Open();

                    SqlCommand cmd = new SqlCommand("select IDKlijent, Stanje\r\nfrom Klijent\r\nwhere Stanje >= @stanja", konekcija);
                   
                    cmd.Parameters.AddWithValue("stanja", boxStanjeVeceOD.Text);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        listBox1.Items.Add(reader[0].ToString() + " " + reader[1].ToString());
                    }




                }
                catch (Exception ex)
                {
                    MessageBox.Show("GRESKA: " + ex.Message);
                }
                finally
                {
                    konekcija.Close();
                }
            }
            else
            {
                MessageBox.Show("Popuni box!");

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // F)
            if(MessageBox.Show("Zelite li da izbrisete klijenta", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    konekcija.Open();

                    SqlCommand cmd = new SqlCommand("DELETE Klijent WHERE IDKlijent =@id", konekcija);

                    cmd.Parameters.AddWithValue("id", dataGridView1.SelectedCells[0].Value.ToString());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Uspesno brisanje");
                   

                    // TODO: This line of code loads data into the 'bankaDataSet.Racun' table. You can move, or remove it, as needed.
                    this.racunTableAdapter.Fill(this.bankaDataSet.Racun);
                    // TODO: This line of code loads data into the 'bankaDataSet.Klijent' table. You can move, or remove it, as needed.
                    this.klijentTableAdapter.Fill(this.bankaDataSet.Klijent);



                }
                catch (Exception ex)
                {
                    MessageBox.Show("GRESKA: " + ex.Message);
                }
                finally
                {
                    konekcija.Close();
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}










