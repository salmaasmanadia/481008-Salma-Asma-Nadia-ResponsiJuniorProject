using Npgsql;
using System.Data;

namespace _481008_Salma_Asma_Nadia_ResponsiJuniorProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=Responsi";

        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);


        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"Select * from st_insert (:_nama, :_id_dep)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_nama", tbNama.Text);
                cmd.Parameters.AddWithValue("_id_dep", cbDep.Text);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Karyawan Berhasil Diinputkan", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    tbNama.Text = cbDep.Text = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Insert FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (r == null)
            {
                MessageBox.Show("Mohon pilih baris yang akan diupdate", "Good!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                conn.Open();
                sql = @"Select * from st_update (:_nama, :_id_dep)";
                cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("_nama", tbNama.Text);
                cmd.Parameters.AddWithValue("_id_dep", cbDep.Text);


                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Karyawan Berhasil DiEdit", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    tbNama.Text = cbDep.Text = null;
                    r = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Delete FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (r == null)
            {
                MessageBox.Show("Mohon pilih baris yang akan dihapus", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Apakah benar anda ingin menghapus data?" + r.Cells["_nama"].Value.ToString() + "?", "Hapus data terkonfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    sql = @"Select * from st_delete (:_nama)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_nama", r.Cells["_nama"].Value.ToString());

                    if ((int)cmd.ExecuteScalar() == 1)
                    {
                        MessageBox.Show("Data Karyawan Berhasil Dihapus", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                        tbNama.Text = cbDep.Text = null;
                        r = null;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message, "Delete FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgv.Rows[e.RowIndex];
                tbNama.Text = r.Cells["_nama"].Value.ToString();
                cbDep.Text = r.Cells["_id_dep"].Value.ToString();
            }
        }
    }
}