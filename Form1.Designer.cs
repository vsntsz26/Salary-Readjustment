namespace Salary_Readjustment
{
    partial class forms
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Calculatr = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtold = new System.Windows.Forms.TextBox();
            this.txtnew = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Calculatr
            // 
            this.Calculatr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculatr.Location = new System.Drawing.Point(539, 348);
            this.Calculatr.Name = "Calculatr";
            this.Calculatr.Size = new System.Drawing.Size(153, 66);
            this.Calculatr.TabIndex = 0;
            this.Calculatr.Text = "Calculate";
            this.Calculatr.UseVisualStyleBackColor = true;
            this.Calculatr.Click += new System.EventHandler(this.Calculatr_Click);
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(34, 130);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(254, 30);
            this.txtname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter your name:";
            // 
            // txtold
            // 
            this.txtold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtold.Location = new System.Drawing.Point(34, 240);
            this.txtold.Multiline = true;
            this.txtold.Name = "txtold";
            this.txtold.Size = new System.Drawing.Size(254, 30);
            this.txtold.TabIndex = 3;
            // 
            // txtnew
            // 
            this.txtnew.AutoSize = true;
            this.txtnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnew.Location = new System.Drawing.Point(30, 301);
            this.txtnew.Name = "txtnew";
            this.txtnew.Size = new System.Drawing.Size(164, 20);
            this.txtnew.TabIndex = 6;
            this.txtnew.Text = "Enter your new salary:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter your old salary :";
            // 
            // txtresult
            // 
            this.txtresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresult.Location = new System.Drawing.Point(454, 80);
            this.txtresult.Multiline = true;
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(326, 210);
            this.txtresult.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(450, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Result:";
            // 
            // txtn
            // 
            this.txtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtn.Location = new System.Drawing.Point(34, 348);
            this.txtn.Multiline = true;
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(254, 29);
            this.txtn.TabIndex = 10;
            // 
            // forms
            // 
            this.ClientSize = new System.Drawing.Size(812, 453);
            this.Controls.Add(this.txtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnew);
            this.Controls.Add(this.txtold);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.Calculatr);
            this.Name = "forms";
            this.Text = "Salary Readjustment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Calculatr;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtold;
        private System.Windows.Forms.Label txtnew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtn;
    }
}

