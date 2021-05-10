
namespace GepteremProjekt
{
    partial class Form_geptermek
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
            this.pictureBoxNevado = new System.Windows.Forms.PictureBox();
            this.buttonJobb = new System.Windows.Forms.Button();
            this.buttonBal = new System.Windows.Forms.Button();
            this.panelErtekeles = new System.Windows.Forms.Panel();
            this.buttonMentes = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNevado)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxNevado
            // 
            this.pictureBoxNevado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxNevado.Location = new System.Drawing.Point(98, 40);
            this.pictureBoxNevado.Name = "pictureBoxNevado";
            this.pictureBoxNevado.Size = new System.Drawing.Size(160, 199);
            this.pictureBoxNevado.TabIndex = 0;
            this.pictureBoxNevado.TabStop = false;
            // 
            // buttonJobb
            // 
            this.buttonJobb.BackgroundImage = global::GepteremProjekt.Properties.Resources.jobb;
            this.buttonJobb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonJobb.Location = new System.Drawing.Point(264, 97);
            this.buttonJobb.Name = "buttonJobb";
            this.buttonJobb.Size = new System.Drawing.Size(80, 76);
            this.buttonJobb.TabIndex = 1;
            this.buttonJobb.UseVisualStyleBackColor = true;
            this.buttonJobb.Click += new System.EventHandler(this.buttonJobb_Click);
            // 
            // buttonBal
            // 
            this.buttonBal.BackgroundImage = global::GepteremProjekt.Properties.Resources.bal;
            this.buttonBal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBal.Location = new System.Drawing.Point(12, 97);
            this.buttonBal.Name = "buttonBal";
            this.buttonBal.Size = new System.Drawing.Size(80, 76);
            this.buttonBal.TabIndex = 2;
            this.buttonBal.UseVisualStyleBackColor = true;
            this.buttonBal.Click += new System.EventHandler(this.buttonBal_Click);
            // 
            // panelErtekeles
            // 
            this.panelErtekeles.Location = new System.Drawing.Point(388, 40);
            this.panelErtekeles.Name = "panelErtekeles";
            this.panelErtekeles.Size = new System.Drawing.Size(567, 352);
            this.panelErtekeles.TabIndex = 3;
            // 
            // buttonMentes
            // 
            this.buttonMentes.BackgroundImage = global::GepteremProjekt.Properties.Resources.ment;
            this.buttonMentes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMentes.Location = new System.Drawing.Point(98, 245);
            this.buttonMentes.Name = "buttonMentes";
            this.buttonMentes.Size = new System.Drawing.Size(80, 72);
            this.buttonMentes.TabIndex = 4;
            this.buttonMentes.UseVisualStyleBackColor = true;
            this.buttonMentes.Click += new System.EventHandler(this.buttonMentes_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.BackgroundImage = global::GepteremProjekt.Properties.Resources.info;
            this.buttonInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonInfo.Location = new System.Drawing.Point(178, 245);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(80, 72);
            this.buttonInfo.TabIndex = 5;
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // Form_geptermek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 532);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.buttonMentes);
            this.Controls.Add(this.panelErtekeles);
            this.Controls.Add(this.buttonBal);
            this.Controls.Add(this.buttonJobb);
            this.Controls.Add(this.pictureBoxNevado);
            this.Name = "Form_geptermek";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNevado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxNevado;
        private System.Windows.Forms.Button buttonJobb;
        private System.Windows.Forms.Button buttonBal;
        private System.Windows.Forms.Panel panelErtekeles;
        private System.Windows.Forms.Button buttonMentes;
        private System.Windows.Forms.Button buttonInfo;
    }
}

