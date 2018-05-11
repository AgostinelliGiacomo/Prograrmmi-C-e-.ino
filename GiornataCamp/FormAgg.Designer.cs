namespace GiornataCamp
{
    partial class FormAgg
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
            this.label1 = new System.Windows.Forms.Label();
            this.nu_par = new System.Windows.Forms.NumericUpDown();
            this.btn_casa = new System.Windows.Forms.Button();
            this.btn_osp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nu_par)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Partita ";
            // 
            // nu_par
            // 
            this.nu_par.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nu_par.Location = new System.Drawing.Point(212, 38);
            this.nu_par.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nu_par.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nu_par.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nu_par.Name = "nu_par";
            this.nu_par.Size = new System.Drawing.Size(130, 31);
            this.nu_par.TabIndex = 1;
            this.nu_par.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nu_par.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_casa
            // 
            this.btn_casa.Location = new System.Drawing.Point(55, 99);
            this.btn_casa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_casa.Name = "btn_casa";
            this.btn_casa.Size = new System.Drawing.Size(114, 40);
            this.btn_casa.TabIndex = 2;
            this.btn_casa.Text = "Goal casa";
            this.btn_casa.UseVisualStyleBackColor = true;
            this.btn_casa.Click += new System.EventHandler(this.btn_casa_Click);
            // 
            // btn_osp
            // 
            this.btn_osp.Location = new System.Drawing.Point(229, 99);
            this.btn_osp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_osp.Name = "btn_osp";
            this.btn_osp.Size = new System.Drawing.Size(114, 40);
            this.btn_osp.TabIndex = 3;
            this.btn_osp.Text = "Goal ospiti";
            this.btn_osp.UseVisualStyleBackColor = true;
            this.btn_osp.Click += new System.EventHandler(this.btn_osp_Click);
            // 
            // FormAgg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 207);
            this.Controls.Add(this.btn_osp);
            this.Controls.Add(this.btn_casa);
            this.Controls.Add(this.nu_par);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormAgg";
            this.Text = "Aggiorna";
            ((System.ComponentModel.ISupportInitialize)(this.nu_par)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nu_par;
        private System.Windows.Forms.Button btn_casa;
        private System.Windows.Forms.Button btn_osp;
    }
}