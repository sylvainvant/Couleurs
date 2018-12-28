using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exo2a
{
    /* cet exercice permet d'illustrer le fonctionnement
     * d'une case à cocher
     * d'un groupe de boutons radio
     * Pour fonctionner de manière exclusive, les boutons radio
     * doivent être placés dans un objet groupBox
     */
    /// <summary>
    /// ce programme change la couleur d'un label en fonction du bouton radio sélectionné
    /// </summary>

    public partial class frmExo2a : Form
    {
        public frmExo2a()
        {
            InitializeComponent();
            this.Height = 194; // hauteur réduite sans boutons radio
            //this.gbxCouleur.Visible = false;
        }
        /// <summary>
        /// lorsque la case est cochée le groupe de boutons de couleur est visible et inversement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>      
        private void chkModifier_CheckedChanged_1(object sender, EventArgs e)
        {
            /* lorsque la case est cochée le groupe de boutons de couleur est visible
           * et inversement ==> corrélation entre les 2 valeurs de propriétés 
           */
            this.gbxCouleur.Visible = true;
            this.gbxCouleur.Visible = this.chkModifier.Checked;  // il s’agit de 2 valeur booléennes

            // ajuster la hauteur du form
            if (this.chkModifier.Checked)
            {
                this.Height = 307; // grande hauteur affichant les boutons radio
            }
            else
            {
                this.Height = 194; // hauteur réduite sans boutons radio
            }
        }
        /// <summary>
        /// si ce bouton est coché, le label devient vert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtVert_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbtVert.Checked)
            {

                this.lblCouleur.BackColor = System.Drawing.Color.Green;
            }

        }

        private void rbtBleu_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbtBleu.Checked)
            {

                this.lblCouleur.BackColor = System.Drawing.Color.Blue;
            }
        }

        private void rbtRouge_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbtRouge.Checked)
            {

                this.lblCouleur.BackColor = System.Drawing.Color.Red;
            }
        }

      
    }
}
