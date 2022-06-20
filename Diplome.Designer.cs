using System.Windows.Forms;

namespace Evenementiel01
{
    partial class Diplome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblDiplome = new System.Windows.Forms.Label();
            this.lblEtablissement = new System.Windows.Forms.Label();
            this.lblAnneeObtention = new System.Windows.Forms.Label();
            this.txtDiplome = new System.Windows.Forms.TextBox();
            this.txtEtablissement = new System.Windows.Forms.TextBox();
            this.dTDiplome = new System.Windows.Forms.DateTimePicker();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.lsvDiplome = new System.Windows.Forms.ListView();
            this.colDiplome = new System.Windows.Forms.ColumnHeader();
            this.colEtablissement = new System.Windows.Forms.ColumnHeader();
            this.colAnnee = new System.Windows.Forms.ColumnHeader();
            this.ctxListView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChercher = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.dgvDiplome = new System.Windows.Forms.DataGridView();
            this.colDiplomes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEtablissements = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnnees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAfficher = new System.Windows.Forms.Button();
            this.ctxListView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiplome)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDiplome
            // 
            this.lblDiplome.AutoSize = true;
            this.lblDiplome.Location = new System.Drawing.Point(52, 44);
            this.lblDiplome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiplome.Name = "lblDiplome";
            this.lblDiplome.Size = new System.Drawing.Size(61, 15);
            this.lblDiplome.TabIndex = 0;
            this.lblDiplome.Text = "Diplôme : ";
            // 
            // lblEtablissement
            // 
            this.lblEtablissement.AutoSize = true;
            this.lblEtablissement.Location = new System.Drawing.Point(52, 99);
            this.lblEtablissement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEtablissement.Name = "lblEtablissement";
            this.lblEtablissement.Size = new System.Drawing.Size(89, 15);
            this.lblEtablissement.TabIndex = 0;
            this.lblEtablissement.Text = "Établissement : ";
            // 
            // lblAnneeObtention
            // 
            this.lblAnneeObtention.AutoSize = true;
            this.lblAnneeObtention.Location = new System.Drawing.Point(52, 158);
            this.lblAnneeObtention.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnneeObtention.Name = "lblAnneeObtention";
            this.lblAnneeObtention.Size = new System.Drawing.Size(112, 15);
            this.lblAnneeObtention.TabIndex = 0;
            this.lblAnneeObtention.Text = "Année d’obtention :";
            // 
            // txtDiplome
            // 
            this.txtDiplome.Location = new System.Drawing.Point(190, 40);
            this.txtDiplome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDiplome.Name = "txtDiplome";
            this.txtDiplome.Size = new System.Drawing.Size(269, 23);
            this.txtDiplome.TabIndex = 1;
            // 
            // txtEtablissement
            // 
            this.txtEtablissement.Location = new System.Drawing.Point(190, 97);
            this.txtEtablissement.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEtablissement.Name = "txtEtablissement";
            this.txtEtablissement.Size = new System.Drawing.Size(269, 23);
            this.txtEtablissement.TabIndex = 1;
            // 
            // dTDiplome
            // 
            this.dTDiplome.Location = new System.Drawing.Point(190, 152);
            this.dTDiplome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dTDiplome.Name = "dTDiplome";
            this.dTDiplome.Size = new System.Drawing.Size(269, 23);
            this.dTDiplome.TabIndex = 2;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(507, 40);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(124, 44);
            this.btnAjouter.TabIndex = 3;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // lsvDiplome
            // 
            this.lsvDiplome.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDiplome,
            this.colEtablissement,
            this.colAnnee});
            this.lsvDiplome.ContextMenuStrip = this.ctxListView;
            this.lsvDiplome.FullRowSelect = true;
            this.lsvDiplome.GridLines = true;
            this.lsvDiplome.Location = new System.Drawing.Point(43, 253);
            this.lsvDiplome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lsvDiplome.Name = "lsvDiplome";
            this.lsvDiplome.Size = new System.Drawing.Size(587, 251);
            this.lsvDiplome.TabIndex = 4;
            this.lsvDiplome.UseCompatibleStateImageBehavior = false;
            this.lsvDiplome.View = System.Windows.Forms.View.Details;
            // 
            // colDiplome
            // 
            this.colDiplome.Text = "Diplôme";
            this.colDiplome.Width = 113;
            // 
            // colEtablissement
            // 
            this.colEtablissement.Text = "Établissement";
            this.colEtablissement.Width = 185;
            // 
            // colAnnee
            // 
            this.colAnnee.Text = "Année d’obtention";
            this.colAnnee.Width = 160;
            // 
            // ctxListView
            // 
            this.ctxListView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.ctxListView.Name = "ctxListView";
            this.ctxListView.Size = new System.Drawing.Size(130, 48);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.ModifierToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.SupprimerToolStripMenuItem_Click);
            // 
            // btnChercher
            // 
            this.btnChercher.Location = new System.Drawing.Point(507, 91);
            this.btnChercher.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnChercher.Name = "btnChercher";
            this.btnChercher.Size = new System.Drawing.Size(124, 44);
            this.btnChercher.TabIndex = 3;
            this.btnChercher.Text = "Chercher";
            this.btnChercher.UseVisualStyleBackColor = true;
            this.btnChercher.Click += new System.EventHandler(this.btnChercher_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(507, 202);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(124, 44);
            this.btnEnregistrer.TabIndex = 3;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.BtnEnregistrer_Click);
            // 
            // dgvDiplome
            // 
            this.dgvDiplome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiplome.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDiplomes,
            this.colEtablissements,
            this.colAnnees});
            this.dgvDiplome.Location = new System.Drawing.Point(654, 253);
            this.dgvDiplome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvDiplome.Name = "dgvDiplome";
            this.dgvDiplome.Size = new System.Drawing.Size(476, 252);
            this.dgvDiplome.TabIndex = 5;
            // 
            // colDiplomes
            // 
            this.colDiplomes.HeaderText = "Diplôme";
            this.colDiplomes.Name = "colDiplomes";
            // 
            // colEtablissements
            // 
            this.colEtablissements.HeaderText = "Établissement";
            this.colEtablissements.Name = "colEtablissements";
            // 
            // colAnnees
            // 
            this.colAnnees.HeaderText = "Année d’obtention";
            this.colAnnees.Name = "colAnnees";
            // 
            // btnAfficher
            // 
            this.btnAfficher.Location = new System.Drawing.Point(1006, 202);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(124, 44);
            this.btnAfficher.TabIndex = 6;
            this.btnAfficher.Text = "Afficher";
            this.btnAfficher.UseVisualStyleBackColor = true;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // Diplome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 527);
            this.Controls.Add(this.btnAfficher);
            this.Controls.Add(this.dgvDiplome);
            this.Controls.Add(this.lsvDiplome);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnChercher);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.dTDiplome);
            this.Controls.Add(this.txtEtablissement);
            this.Controls.Add(this.txtDiplome);
            this.Controls.Add(this.lblAnneeObtention);
            this.Controls.Add(this.lblEtablissement);
            this.Controls.Add(this.lblDiplome);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Diplome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Diplome_Load);
            this.ctxListView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiplome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDiplome;
        private System.Windows.Forms.Label lblEtablissement;
        private System.Windows.Forms.Label lblAnneeObtention;
        private System.Windows.Forms.TextBox txtDiplome;
        private System.Windows.Forms.TextBox txtEtablissement;
        private System.Windows.Forms.DateTimePicker dTDiplome;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.ListView lsvDiplome;
        private ColumnHeader colDiplome;
        private ColumnHeader colEtablissement;
        private ColumnHeader colAnnee;
        private Button btnChercher;
        private Button btnEnregistrer;
        private ContextMenuStrip ctxListView;
        private ToolStripMenuItem modifierToolStripMenuItem;
        private ToolStripMenuItem supprimerToolStripMenuItem;
        private DataGridView dgvDiplome;
        private DataGridViewTextBoxColumn colDiplomes;
        private DataGridViewTextBoxColumn colEtablissements;
        private DataGridViewTextBoxColumn colAnnees;
        private Button btnAfficher;
    }
}