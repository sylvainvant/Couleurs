namespace Exo2a
{
    partial class frmExo2a
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.chkModifier = new System.Windows.Forms.CheckBox();
            this.gbxCouleur = new System.Windows.Forms.GroupBox();
            this.rbtBleu = new System.Windows.Forms.RadioButton();
            this.rbtVert = new System.Windows.Forms.RadioButton();
            this.rbtRouge = new System.Windows.Forms.RadioButton();
            this.lblCouleur = new System.Windows.Forms.Label();
            this.gbxCouleur.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Démonstration des cases à cocher \r\net des boutons d\' options\r\n";
            // 
            // chkModifier
            // 
            this.chkModifier.AutoSize = true;
            this.chkModifier.Location = new System.Drawing.Point(18, 60);
            this.chkModifier.Name = "chkModifier";
            this.chkModifier.Size = new System.Drawing.Size(112, 17);
            this.chkModifier.TabIndex = 2;
            this.chkModifier.Text = "Modifier la couleur";
            this.chkModifier.UseVisualStyleBackColor = true;
            this.chkModifier.CheckedChanged += new System.EventHandler(this.chkModifier_CheckedChanged_1);
            // 
            // gbxCouleur
            // 
            this.gbxCouleur.Controls.Add(this.rbtBleu);
            this.gbxCouleur.Controls.Add(this.rbtVert);
            this.gbxCouleur.Controls.Add(this.rbtRouge);
            this.gbxCouleur.Location = new System.Drawing.Point(135, 149);
            this.gbxCouleur.Name = "gbxCouleur";
            this.gbxCouleur.Size = new System.Drawing.Size(137, 100);
            this.gbxCouleur.TabIndex = 4;
            this.gbxCouleur.TabStop = false;
            this.gbxCouleur.Text = "Couleur";
            this.gbxCouleur.Visible = false;
            // 
            // rbtBleu
            // 
            this.rbtBleu.AutoSize = true;
            this.rbtBleu.Location = new System.Drawing.Point(24, 75);
            this.rbtBleu.Name = "rbtBleu";
            this.rbtBleu.Size = new System.Drawing.Size(46, 17);
            this.rbtBleu.TabIndex = 2;
            this.rbtBleu.Text = "&Bleu";
            this.rbtBleu.UseVisualStyleBackColor = true;
            this.rbtBleu.CheckedChanged += new System.EventHandler(this.rbtBleu_CheckedChanged);
            // 
            // rbtVert
            // 
            this.rbtVert.AutoSize = true;
            this.rbtVert.Location = new System.Drawing.Point(24, 52);
            this.rbtVert.Name = "rbtVert";
            this.rbtVert.Size = new System.Drawing.Size(44, 17);
            this.rbtVert.TabIndex = 1;
            this.rbtVert.Text = "&Vert";
            this.rbtVert.UseVisualStyleBackColor = true;
            this.rbtVert.CheckedChanged += new System.EventHandler(this.rbtVert_CheckedChanged);
            // 
            // rbtRouge
            // 
            this.rbtRouge.AutoSize = true;
            this.rbtRouge.Checked = true;
            this.rbtRouge.Location = new System.Drawing.Point(24, 29);
            this.rbtRouge.Name = "rbtRouge";
            this.rbtRouge.Size = new System.Drawing.Size(57, 17);
            this.rbtRouge.TabIndex = 0;
            this.rbtRouge.TabStop = true;
            this.rbtRouge.Text = "&Rouge";
            this.rbtRouge.UseVisualStyleBackColor = true;
            this.rbtRouge.CheckedChanged += new System.EventHandler(this.rbtRouge_CheckedChanged);
            // 
            // lblCouleur
            // 
            this.lblCouleur.BackColor = System.Drawing.Color.Red;
            this.lblCouleur.Location = new System.Drawing.Point(136, 47);
            this.lblCouleur.Name = "lblCouleur";
            this.lblCouleur.Padding = new System.Windows.Forms.Padding(3);
            this.lblCouleur.Size = new System.Drawing.Size(136, 91);
            this.lblCouleur.TabIndex = 3;
            this.lblCouleur.Text = "La couleur choisie";
            this.lblCouleur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmExo2a
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblCouleur);
            this.Controls.Add(this.gbxCouleur);
            this.Controls.Add(this.chkModifier);
            this.Controls.Add(this.label1);
            this.Name = "frmExo2a";
            this.Text = "Exercice 2a : Couleurs";
            this.gbxCouleur.ResumeLayout(false);
            this.gbxCouleur.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkModifier;
        private System.Windows.Forms.GroupBox gbxCouleur;
        private System.Windows.Forms.RadioButton rbtBleu;
        private System.Windows.Forms.RadioButton rbtVert;
        private System.Windows.Forms.RadioButton rbtRouge;
        private System.Windows.Forms.Label lblCouleur;
    }
}

