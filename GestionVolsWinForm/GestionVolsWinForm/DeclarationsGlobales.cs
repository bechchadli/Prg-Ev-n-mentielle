using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionVolsWinForm
{
    static class DeclarationsGlobales
    {
        public static List<Pilote> pilotes;
        public static List<Avion> avions;
        public static List<Vol> vols;

        static BinaryFormatter bf = new BinaryFormatter();

        static FileStream fichier;
        public static void serialiser_tous()
        {
            //Partie Pilotes
            fichier = new FileStream("Pilotefichier.dat", FileMode.Create, FileAccess.Write);
            bf.Serialize(fichier, pilotes);
            fichier.Close();
            //Partie Avions
            fichier = new FileStream("Avionfichier.dat", FileMode.Create, FileAccess.Write);
            bf.Serialize(fichier, avions);
            fichier.Close();
            //Parie Vols
            fichier = new FileStream("Volfichier.dat", FileMode.Create, FileAccess.Write);
            bf.Serialize(fichier, vols);
            fichier.Close();
        }
        public static void deserialiser_tous()
        {
            //Partie Pilotes
            try
            {
                fichier = new FileStream("Pilotefichier.dat", FileMode.Open, FileAccess.Read);
                pilotes = (List<Pilote>)bf.Deserialize(fichier);
                fichier.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Impoossible d'ouvrir le Fichier Pilote", "Erreur Fichier");
                pilotes = new List<Pilote>();
                //fichier.Dispose();
            }
            //Partie Avions
            try
            {
                fichier = new FileStream("Avionfichier.dat", FileMode.Open, FileAccess.Read);
                avions = (List<Avion>)bf.Deserialize(fichier);
                fichier.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Impoossible d'ouvrir le Fichier Avion","Erreur Fichier");
                avions = new List<Avion>();
                //fichier.Dispose();
            }
            //Partie Vols
            try
            {
                fichier = new FileStream("Volfichier.dat", FileMode.Open, FileAccess.Read);
                vols = (List<Vol>)bf.Deserialize(fichier);
                fichier.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Impoossible d'ouvrir le Fichier Vol", "Erreur Fichier");
                vols = new List<Vol>();
                //fichier.Dispose();
            }
        }

        //Pour vider tous les TextBox
        public static void viderTextBox(Form f)
        {
            foreach (Control c in f.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Clear();
                }
                else if (c is ComboBox)
                {
                    ComboBox t = (ComboBox)c;
                    t.Text = "";
                }
                
            }
        }

        //Pour ne pas Ecrire le meme code de La validation plusieurs fois
        public static void ValidationTxtVide(Control monTxt, string msg, ErrorProvider ep, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(monTxt.Text))
            {
                e.Cancel = true;
                ep.SetError(monTxt, msg);
            }
            else
            {
                e.Cancel = false;
                ep.SetError(monTxt, null);
            }
        }
        public static void ValidationTxtNumerique(TextBox monTxt, string msg, ErrorProvider ep, CancelEventArgs e)
        {
            try
            {
                int.Parse(monTxt.Text);
                e.Cancel = false;
                ep.SetError(monTxt, null);
            }
            catch (Exception)
            {
                e.Cancel = true;
                ep.SetError(monTxt, msg);
            }
        }
    }
}
