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
    // delegato alla gestione dell'evento cambio risultato
    public delegate void CambioRis( int part, int sqad);

    public partial class FormAgg : Form
    {
        int par;
        int sq;

        // creo un nuovo evento
        public event CambioRis RisultatoCambiato;

        public FormAgg()
        {
            InitializeComponent();
        }

        // 
        private void btn_casa_Click(object sender, EventArgs e)
        {
            sq = 0;
            AvvertiModifica();
        }

        private void btn_osp_Click(object sender, EventArgs e)
        {
            sq = 1;
            AvvertiModifica();
        }

        void AvvertiModifica()
        {
            par = Convert.ToInt32(nu_par.Value);
            if (RisultatoCambiato != null)
                RisultatoCambiato(par-1, sq);
        }


    }
}
