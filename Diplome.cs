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

namespace Evenementiel01
{
    public partial class Diplome : Form
    {
        int indiceItem = -1;
        public Diplome()
        {
            InitializeComponent();
        }
        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            if (btnAjouter.Text == "Ajouter")
            {
                string[] tInfos = new string[] { txtDiplome.Text, txtEtablissement.Text, dTDiplome.Value.ToShortDateString() };
                ListViewItem list = new ListViewItem(tInfos);

                lsvDiplome.Items.Add(list);
                dgvDiplome.Rows.Add(tInfos);
                txtDiplome.Text = "";
                txtEtablissement.Text = "";

            }
            else
            {

                lsvDiplome.Items[indiceItem].SubItems[0].Text = txtDiplome.Text;
                lsvDiplome.Items[indiceItem].SubItems[1].Text = txtEtablissement.Text;
                lsvDiplome.Items[indiceItem].SubItems[2].Text = dTDiplome.Value.ToShortDateString();
                btnAjouter.Text = "Ajouter";
            }
        }

        private void Diplome_Load(object sender, EventArgs e)
        {
            StreamReader readlist = new StreamReader("mesDiplomes.txt");
            string ligne = string.Empty;
            while ((ligne = readlist.ReadLine()) != null)
            {
                string[] tabLigne = ligne.Split('/');
                ListViewItem itemList = new ListViewItem(tabLigne);
                lsvDiplome.Items.Add(itemList);
            }
            readlist.Close();
        }
        private void ModifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lsvDiplome.SelectedItems.Count > 0)
            {
                indiceItem = lsvDiplome.SelectedIndices[0];
                txtDiplome.Text = lsvDiplome.Items[indiceItem].SubItems[0].Text;
                txtEtablissement.Text = lsvDiplome.Items[indiceItem].SubItems[1].Text;
                dTDiplome.Text = lsvDiplome.Items[indiceItem].SubItems[2].Text;
                btnAjouter.Text = "Modifier";
            }
        }
        private void SupprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lsvDiplome.SelectedItems.Count > 0)
            {

                DialogResult resultat = MessageBox.Show("Voulez-vous vraiment supprimes la ligne?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resultat == DialogResult.Yes)
                {
                    lsvDiplome.Items.RemoveAt(lsvDiplome.SelectedIndices[0]);
                }
            }
        }
        private void btnChercher_Click(object sender, EventArgs e)
        {
            bool existe = false;
            foreach (ListViewItem item in lsvDiplome.Items)
            {
                if (item.SubItems[0].Text == txtDiplome.Text)
                {
                    existe = true;
                }

            }

            if (existe)
            {
                MessageBox.Show("Ce diplôme existe déjà");
            }
            else
            {
                MessageBox.Show("Ce diplôme n’existe pas");
            }
        }

        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            StreamWriter saveList = new StreamWriter("mesDiplomes.txt", false);
            foreach (ListViewItem maListe in lsvDiplome.Items)
            {
                saveList.WriteLine(maListe.SubItems[0].Text + "/" + maListe.SubItems[1].Text + "/" + maListe.SubItems[2].Text);
            }
            saveList.Close();
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            string etab = dgvDiplome.Rows[0].Cells[1].Value.ToString();
            MessageBox.Show(etab);
        }
    }
}
