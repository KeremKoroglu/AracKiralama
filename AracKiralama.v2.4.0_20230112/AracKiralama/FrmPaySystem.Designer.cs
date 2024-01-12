namespace AracKiralama
{
    partial class FrmPaySystem
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
            this.GrpPaySystem = new System.Windows.Forms.GroupBox();
            this.LblModel = new System.Windows.Forms.Label();
            this.CmbModel = new System.Windows.Forms.ComboBox();
            this.CmbRenter = new System.Windows.Forms.ComboBox();
            this.LblRenter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GrpPaySystem
            // 
            this.GrpPaySystem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.GrpPaySystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GrpPaySystem.Location = new System.Drawing.Point(12, 86);
            this.GrpPaySystem.Name = "GrpPaySystem";
            this.GrpPaySystem.Size = new System.Drawing.Size(776, 152);
            this.GrpPaySystem.TabIndex = 0;
            this.GrpPaySystem.TabStop = false;
            this.GrpPaySystem.Text = "Ödeme";
            // 
            // LblModel
            // 
            this.LblModel.AutoSize = true;
            this.LblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblModel.Location = new System.Drawing.Point(87, 27);
            this.LblModel.Name = "LblModel";
            this.LblModel.Size = new System.Drawing.Size(82, 25);
            this.LblModel.TabIndex = 1;
            this.LblModel.Text = "Model : ";
            // 
            // CmbModel
            // 
            this.CmbModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbModel.FormattingEnabled = true;
            this.CmbModel.Items.AddRange(new object[] {
            "Toyota Corolla"});
            this.CmbModel.Location = new System.Drawing.Point(175, 24);
            this.CmbModel.Name = "CmbModel";
            this.CmbModel.Size = new System.Drawing.Size(172, 33);
            this.CmbModel.TabIndex = 2;
            // 
            // CmbRenter
            // 
            this.CmbRenter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbRenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbRenter.FormattingEnabled = true;
            this.CmbRenter.Location = new System.Drawing.Point(520, 24);
            this.CmbRenter.Name = "CmbRenter";
            this.CmbRenter.Size = new System.Drawing.Size(172, 33);
            this.CmbRenter.TabIndex = 4;
            // 
            // LblRenter
            // 
            this.LblRenter.AutoSize = true;
            this.LblRenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblRenter.Location = new System.Drawing.Point(404, 27);
            this.LblRenter.Name = "LblRenter";
            this.LblRenter.Size = new System.Drawing.Size(110, 25);
            this.LblRenter.TabIndex = 3;
            this.LblRenter.Text = "Kiralayan : ";
            // 
            // FrmPaySystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.CmbRenter);
            this.Controls.Add(this.LblRenter);
            this.Controls.Add(this.CmbModel);
            this.Controls.Add(this.LblModel);
            this.Controls.Add(this.GrpPaySystem);
            this.Name = "FrmPaySystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödeme Sistemi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPaySystem_FormClosing);
            this.Load += new System.EventHandler(this.FrmPaySystem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpPaySystem;
        private System.Windows.Forms.Label LblModel;
        private System.Windows.Forms.ComboBox CmbModel;
        private System.Windows.Forms.ComboBox CmbRenter;
        private System.Windows.Forms.Label LblRenter;
    }
}