using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace projetCS2020_2021
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtTva_TextChanged(object sender, EventArgs e)
        {
            txtTva.Text = Convert.ToString(0.2);
        }
        /**
         *bouton quitter 
         * 
         */
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez fermer le formulaire?");
            if (result == DialogResult.OK)
            {
                Close();
            }
        }
        /**
         * bouton réinitialiser
         * 
         */
        private void btnR_Click(object sender, EventArgs e)
        {
            txtPrixht.Text = Convert.ToString(0);
            txtPrixttc.Text = Convert.ToString(0);
            cb.SelectedItem = "Pas de réduction";
            txtPrixbase.Text = Convert.ToString(0);
        }

        /**
         *bouton calculer 
         * 
         */
        private void btnCalc_Click(object sender, EventArgs e)
        {
            /**
             * red: réduction
             * prixB: prix de base
             */
            double red;
            double prixB ;

            /**
             * calcul du prix du ticket en fonction des cartes et des classes
             */
            if (Convert.ToString(listbox.SelectedItem) == "Premiere classe") { prixB =Double.Parse(txtPrixbase.Text)*1.2; }
            else { prixB = Double.Parse(txtPrixbase.Text); }

            if (Convert.ToString(cb.SelectedItem) == "Carte jeune") { red = 0.4*prixB; }
            else if (Convert.ToString(cb.SelectedItem) == "Carte adulte") { red = 0.3 * prixB; }
            else if (Convert.ToString(cb.SelectedItem) == "Carte famille") { red = 0.5 * prixB; }
            else { red = 0; }
            txtPrixht.Text = Convert.ToString(Pht(red,prixB));
            txtPrixttc.Text = Convert.ToString(Pttc(Pht(red, prixB)));

        }
        /**
         * calcul du prix hors taxe
         */
         static double Pht(double red, double prixb) 
         {
            double pht = prixb - red;
            return pht;
        }
         /**
          * calcul du prix toute taxe
          */
         static double Pttc(double pht)
         {
             double pttc =1.2*pht ;
             return pttc;
         }
         /**
          * Initialiser les champs lors du chargement du formulaire
          */
         private void Form1_Load(object sender, EventArgs e)
         {
             txtPrixttc.Enabled = false;
             txtPrixht.Enabled = false;
             txtPrixttc.BackColor = Color.DeepSkyBlue;
             txtPrixht.BackColor = Color.Lime;
             cb.SelectedItem = "Pas de réduction";
         }

         private void cb_SelectedIndexChanged(object sender, EventArgs e)
         {

         }

    }
}
