namespace quizz_sua_area_de_ti
{
    partial class Form8
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
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.lblSegundo = new System.Windows.Forms.Label();
            this.btn_reiniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.AutoSize = true;
            this.lblPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrincipal.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblPrincipal.Location = new System.Drawing.Point(518, 214);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(152, 55);
            this.lblPrincipal.TabIndex = 0;
            this.lblPrincipal.Text = "label1";
            // 
            // lblSegundo
            // 
            this.lblSegundo.AutoSize = true;
            this.lblSegundo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblSegundo.Location = new System.Drawing.Point(518, 346);
            this.lblSegundo.Name = "lblSegundo";
            this.lblSegundo.Size = new System.Drawing.Size(152, 55);
            this.lblSegundo.TabIndex = 1;
            this.lblSegundo.Text = "label1";
            // 
            // btn_reiniciar
            // 
            this.btn_reiniciar.BackColor = System.Drawing.Color.DarkViolet;
            this.btn_reiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_reiniciar.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reiniciar.ForeColor = System.Drawing.Color.GhostWhite;
            this.btn_reiniciar.Location = new System.Drawing.Point(454, 522);
            this.btn_reiniciar.Name = "btn_reiniciar";
            this.btn_reiniciar.Size = new System.Drawing.Size(263, 87);
            this.btn_reiniciar.TabIndex = 3;
            this.btn_reiniciar.Text = "Reiniciar";
            this.btn_reiniciar.UseVisualStyleBackColor = false;
            this.btn_reiniciar.Click += new System.EventHandler(this.btn_reiniciar_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(20)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.btn_reiniciar);
            this.Controls.Add(this.lblSegundo);
            this.Controls.Add(this.lblPrincipal);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.Label lblSegundo;
        private System.Windows.Forms.Button btn_reiniciar;
    }
}