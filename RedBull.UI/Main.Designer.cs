namespace RedBull.UI
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.btnInsomnia = new System.Windows.Forms.Button();
            this.btnCure = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnInsomnia
            // 
            this.btnInsomnia.BackColor = System.Drawing.SystemColors.Control;
            this.btnInsomnia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsomnia.Location = new System.Drawing.Point(12, 12);
            this.btnInsomnia.Name = "btnInsomnia";
            this.btnInsomnia.Size = new System.Drawing.Size(144, 68);
            this.btnInsomnia.TabIndex = 0;
            this.btnInsomnia.Text = "Insomnia";
            this.btnInsomnia.UseVisualStyleBackColor = false;
            this.btnInsomnia.Click += new System.EventHandler(this.btnInsomnia_Click);
            // 
            // btnCure
            // 
            this.btnCure.BackColor = System.Drawing.SystemColors.Control;
            this.btnCure.Enabled = false;
            this.btnCure.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCure.Location = new System.Drawing.Point(162, 12);
            this.btnCure.Name = "btnCure";
            this.btnCure.Size = new System.Drawing.Size(110, 68);
            this.btnCure.TabIndex = 1;
            this.btnCure.Text = "Cure";
            this.btnCure.UseVisualStyleBackColor = false;
            this.btnCure.Click += new System.EventHandler(this.btnCure_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTimer.Location = new System.Drawing.Point(12, 94);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(260, 23);
            this.lblTimer.TabIndex = 2;
            this.lblTimer.Text = "Inactive";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(284, 126);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnCure);
            this.Controls.Add(this.btnInsomnia);
            this.Name = "Main";
            this.Text = "Insomniac";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInsomnia;
        private System.Windows.Forms.Button btnCure;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer;
    }
}

