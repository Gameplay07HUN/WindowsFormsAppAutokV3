using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppAuutók;

namespace WindowsFormsAppAutokV3
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = null;
        MySqlCommand cmd = null;
        autoV2 db = new autoV2("localhost", "root", "", "autokv2");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "autokv2";
            conn = new MySqlConnection(builder.ConnectionString);
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + "A program leáll!");
                Environment.Exit(0);
            }
            finally
            {
                conn.Close();
            }
            dataGridViewGyumolcsokFelepitese();
            dataGridViewAutokUpdate();
        }

        private void dataGridViewGyumolcsokFelepitese()
        {
            DataGridViewColumn col_ID = new DataGridViewColumn();
            {
                col_ID.Name = "id";
                col_ID.ReadOnly = true;
                col_ID.CellTemplate = new DataGridViewTextBoxCell();
                col_ID.HeaderText = "Azonosító";
            }
            dataGridViewAutok.Columns.Add(col_ID);
            DataGridViewColumn col_Marka = new DataGridViewColumn();
            {
                col_Marka.Name = "marka";
                col_Marka.HeaderText = "Márka";
                col_Marka.CellTemplate = new DataGridViewTextBoxCell();
            }
            dataGridViewAutok.Columns.Add(col_Marka);
            DataGridViewColumn col_Nev = new DataGridViewColumn();
            {
                col_Nev.Name = "nev";
                col_Nev.HeaderText = "Neve";
                col_Nev.CellTemplate = new DataGridViewTextBoxCell();
            }
            dataGridViewAutok.Columns.Add(col_Nev);
            DataGridViewColumn col_Motor = new DataGridViewColumn();
            {
                col_Motor.Name = "motor";
                col_Motor.HeaderText = "Motor";
                col_Motor.CellTemplate = new DataGridViewTextBoxCell();
            }
            dataGridViewAutok.Columns.Add(col_Motor);
            DataGridViewColumn col_Uzembehelyezve = new DataGridViewColumn();
            {
                col_Uzembehelyezve.CellTemplate = new DataGridViewTextBoxCell();
                col_Uzembehelyezve.HeaderText = "Üzembehelyezve";
                col_Uzembehelyezve.Name = "uzembehelyezve";
            }
            dataGridViewAutok.Columns.Add(col_Uzembehelyezve);
            DataGridViewColumn col_Szin = new DataGridViewColumn();
            {
                col_Szin.CellTemplate = new DataGridViewTextBoxCell();
                col_Szin.HeaderText = "Szín";
                col_Szin.Name = "szin";
            }
            dataGridViewAutok.Columns.Add(col_Szin);

            dataGridViewAutok.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dataGridViewAutokUpdate()
        {
            dataGridViewAutok.Rows.Clear();
            foreach (auto rekord in db.getAllAuto())
            {
                int sorIndex = dataGridViewAutok.Rows.Add();
                DataGridViewRow getUjSor = dataGridViewAutok.Rows[sorIndex];
                getUjSor.Cells["id"].Value = rekord.Id;
                getUjSor.Cells["marka"].Value = rekord.Marka;
                getUjSor.Cells["nev"].Value = rekord.Nev;
                getUjSor.Cells["motor"].Value = rekord.Motor;
                getUjSor.Cells["uzembehelyezve"].Value = rekord.Uzembehelyezve;
                getUjSor.Cells["szin"].Value = rekord.Szin;

            }
        }

        private void dataGridViewAutok_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewAutok.SelectedRows.Count == 0)
            {
                return;
            }
            DataGridViewRow rekord = dataGridViewAutok.SelectedRows[0];
            if (rekord.Cells["id"].Value == null || rekord.Cells["marka"] == null)
            {
                return;
            }

            textBoxMarka.Text = rekord.Cells["marka"].Value.ToString();
            textBoxId.Text = rekord.Cells["id"].Value.ToString();
            textBoxNev.Text = rekord.Cells["nev"].Value.ToString();
            textBoxMotor.Text = rekord.Cells["motor"].Value.ToString();
            numericUpDownUzembehelyezve.Value = decimal.Parse(rekord.Cells["uzembehelyezve"].Value.ToString());
            textBoxSzin.Text = rekord.Cells["szin"].Value.ToString();
        }

        private bool nincsenek_adatok()
        {
            if (string.IsNullOrEmpty(textBoxMarka.Text))
            {
                MessageBox.Show("Adja meg az autó márkáját!");
                textBoxMarka.Focus();
                return true;
            }
            if (string.IsNullOrEmpty(textBoxNev.Text))
            {
                MessageBox.Show("Adja meg az autó nevét!");
                textBoxNev.Focus();
                return true;
            }
            if (string.IsNullOrEmpty(textBoxMotor.Text))
            {
                MessageBox.Show("Adja meg az autó motorjának a nevét!");
                textBoxMotor.Focus();
                return true;
            }
            if (numericUpDownUzembehelyezve.Value > DateTime.Now.Year)
            {
                MessageBox.Show("Érvénytelen évjárat!");
                numericUpDownUzembehelyezve.Value = DateTime.Now.Year;
                numericUpDownUzembehelyezve.Focus();
                return true;
            }
            if (string.IsNullOrEmpty(textBoxSzin.Text))
            {
                MessageBox.Show("Nem adott meg színt!");
                textBoxSzin.Focus();
                return true;
            }
            return false;
        }

        private void buttonUj_Click(object sender, EventArgs e)
        {
            if (nincsenek_adatok())
            {
                return;
            }
            cmd.CommandText = "INSERT INTO `autokv2` (`id`,`marka`,`nev`,`motor`,`uzembehelyezve`,`szin`) VALUES (NULL, @marka, @nev, @motor, @uzembehelyezve ,@szin);";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@marka", textBoxMarka.Text);
            cmd.Parameters.AddWithValue("@nev", textBoxNev.Text);
            cmd.Parameters.AddWithValue("@motor", textBoxMotor.Text);
            cmd.Parameters.AddWithValue("@uzembehelyezve", numericUpDownUzembehelyezve.Value.ToString());
            cmd.Parameters.AddWithValue("@szin", textBoxSzin.Text);
            conn.Open();
            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Sikeresen rögzítve!");
                    textBoxSzin.Text = "";
                    numericUpDownUzembehelyezve.Value = numericUpDownUzembehelyezve.Minimum;
                    textBoxMotor.Text = "";
                    textBoxNev.Text = "";
                    textBoxMarka.Text = "";
                    textBoxId.Text = "";
                }
                else
                {
                    MessageBox.Show("Sikertelen rögzítés!");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            conn.Close();
            dataGridViewAutokUpdate();
        }

        private void buttonModosit_Click(object sender, EventArgs e)
        {
            if (dataGridViewAutok.SelectedRows.Count < 0)
            {
                MessageBox.Show("Nincs kijelölve autó!");
                return;
            }
            cmd.CommandText = "UPDATE `autokv2` SET `marka` = @marka, `nev` = @nev, `motor` = @motor, `uzembehelyezve` = @uzembehelyezve, `szin` = @szin WHERE `autokv2`.`id` = @id;";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", textBoxId.Text);
            cmd.Parameters.AddWithValue("@marka", textBoxMarka.Text);
            cmd.Parameters.AddWithValue("@nev", textBoxNev.Text);
            cmd.Parameters.AddWithValue("@motor", textBoxMotor.Text);
            cmd.Parameters.AddWithValue("@uzembehelyezve", numericUpDownUzembehelyezve.Value);
            cmd.Parameters.AddWithValue("@szin", textBoxSzin.Text);
            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Módosítás sikeres!");
                conn.Close();
                textBoxId.Text = "";
                textBoxMarka.Text = "";
                textBoxNev.Text = "";
                textBoxMotor.Text = "";
                numericUpDownUzembehelyezve.Value = numericUpDownUzembehelyezve.Minimum;
                textBoxSzin.Text = "";
                dataGridViewAutokUpdate();
            }
            else
            {
                MessageBox.Show("Az adatok modosítása sikerleten!");
            }
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private void buttonTorles_Click(object sender, EventArgs e)
        {
            if (dataGridViewAutok.SelectedRows.Count < 0)
            {
                return;
            }
            cmd.CommandText = "DELETE FROM `autokv2` WHERE `id` = @id";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", textBoxId.Text);
            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Törlés sikeres!");
                conn.Close();
                textBoxId.Text = "";
                textBoxMarka.Text = "";
                textBoxNev.Text = "";
                textBoxMotor.Text = "";
                numericUpDownUzembehelyezve.Value = numericUpDownUzembehelyezve.Minimum;
                textBoxSzin.Text = "";
                dataGridViewAutokUpdate();
            }
            else
            {
                MessageBox.Show("Törlés sikertelen!");
            }
        }
    }
}
