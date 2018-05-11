using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GiornataCamp
{
    public partial class FormMain : Form
    {
        Partite gior = new Partite();
        FormAgg fg = null;

        public FormMain()
        {
            InitializeComponent();
        }

        // vcaricamento partite
        private void btn_carica_Click(object sender, EventArgs e)
        {
            gior.Carica("partite.txt");
            Visualizza();
        }

        void Visualizza()
        {
            list_par.Items.Clear();
            ListViewItem x;
            for (int i = 0; i < gior.ne; i++)
            {
                x = new ListViewItem((i + 1).ToString());
                x.SubItems.Add(gior.tab[i, 0].nome);
                x.SubItems.Add(gior.tab[i, 1].nome);
                x.SubItems.Add(gior.tab[i, 0].goal.ToString());
                x.SubItems.Add(gior.tab[i, 1].goal.ToString());
                list_par.Items.Add(x);
            }

        }

        // funzione delagato alla gestione dell'evento click di aggiorna
        private void menu_agg_Click(object sender, EventArgs e)
        {
            if (fg == null)
            {
                fg = new FormAgg();
                fg.RisultatoCambiato += AggiornaPartite;
            }
            fg.Show();
        }

        void AggiornaPartite(int r, int c)
        {
            gior.tab[r, c].goal++;
            Visualizza();
        }
    }
}
