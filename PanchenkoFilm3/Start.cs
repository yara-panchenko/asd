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

namespace PanchenkoFilm
{
    public partial class Start : Form
    {
        SqlConnection con;
        SqlDataAdapter Saalide_adapter;
        public int i = 0, j = 0;
        ListBox saalide_list;
        int[] read_list;
        int[] kohad_list;

        public Start()
        {
            con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\AppData\Filmid.mdf; Integrated Security = True");
            this.Text = "Super Kino";
            //this.BackgroundImage = Image.FromFile"";
            this.Size = new Size(360, 300);
            con.Open();
            Saalide_adapter = new SqlDataAdapter("Select Saalinimetus FROM Saalid_tabel", con);
            DataTable salid_tabel = new DataTable();
            Saalide_adapter.Fill(salid_tabel);
            saalide_list = new ListBox();
            saalide_list.Location = new Point(10, 10);
            saalide_list.Font = new Font(DefaultFont.FontFamily, 14);
            saalide_list.Size = new Size(150, 30);
            foreach (DataRow row in salid_tabel.Rows)
            {
                saalide_list.Items.Add(row["Saalinimetus"]);
            }
            this.Controls.Add(saalide_list);
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (saalide_list.SelectedIndex == 1)
            {
                i = 5; j = 5;
            }
            else if (saalide_list.SelectedIndex == 2)
            {
                i = 10; j = 10;
            }
            else if (saalide_list.SelectedIndex == 3)
            {
                i = 15; j = 15;
            }
            else
            {
                MessageBox.Show("Viga!", "Vaja saal valida");
            }
            Saalid saalid = new Saalid(i, j);
            saalid.Show();
        }

    }
}
