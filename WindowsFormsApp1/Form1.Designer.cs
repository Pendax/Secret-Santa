namespace WindowsFormsApp1
{
    partial class Form1
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
            this.Fordel = new System.Windows.Forms.Button();
            this.Navne = new System.Windows.Forms.ComboBox();
            this.Glemt = new System.Windows.Forms.Button();
            this.MANGLER = new System.Windows.Forms.Button();
            this.genuddel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Fordel
            // 
            this.Fordel.BackColor = System.Drawing.Color.Transparent;
            this.Fordel.Location = new System.Drawing.Point(11, 4);
            this.Fordel.Name = "Fordel";
            this.Fordel.Size = new System.Drawing.Size(118, 75);
            this.Fordel.TabIndex = 0;
            this.Fordel.Text = "Fordel nisser";
            this.Fordel.UseVisualStyleBackColor = false;
            this.Fordel.Click += new System.EventHandler(this.Fordel_Click);
            // 
            // Navne
            // 
            this.Navne.FormattingEnabled = true;
            this.Navne.Items.AddRange(new object[] {
            "Andreas",
            "Arne",
            "Frederik",
            "Henning",
            "Jannie",
            "Karoline",
            "Kristian",
            "Lise",
            "Maj",
            "Mikkel",
            "Mogens ",
            "Niklas",
            "Per",
            "Rikke",
            "Simon"});
            this.Navne.Location = new System.Drawing.Point(12, 4);
            this.Navne.Name = "Navne";
            this.Navne.Size = new System.Drawing.Size(116, 21);
            this.Navne.Sorted = true;
            this.Navne.TabIndex = 1;
            this.Navne.Visible = false;
            // 
            // Glemt
            // 
            this.Glemt.BackColor = System.Drawing.Color.Transparent;
            this.Glemt.Location = new System.Drawing.Point(11, 31);
            this.Glemt.Name = "Glemt";
            this.Glemt.Size = new System.Drawing.Size(118, 29);
            this.Glemt.TabIndex = 2;
            this.Glemt.Text = "Send nisse\r\n";
            this.Glemt.UseVisualStyleBackColor = false;
            this.Glemt.Visible = false;
            this.Glemt.Click += new System.EventHandler(this.GlemtNisse_Click);
            // 
            // MANGLER
            // 
            this.MANGLER.BackColor = System.Drawing.Color.Transparent;
            this.MANGLER.Location = new System.Drawing.Point(11, 66);
            this.MANGLER.Name = "MANGLER";
            this.MANGLER.Size = new System.Drawing.Size(118, 29);
            this.MANGLER.TabIndex = 4;
            this.MANGLER.Text = "Glemt Ønskeliste";
            this.MANGLER.UseVisualStyleBackColor = false;
            this.MANGLER.Visible = false;
            this.MANGLER.Click += new System.EventHandler(this.MANGLER_Click);
            // 
            // genuddel
            // 
            this.genuddel.BackColor = System.Drawing.Color.Transparent;
            this.genuddel.Location = new System.Drawing.Point(11, 101);
            this.genuddel.Name = "genuddel";
            this.genuddel.Size = new System.Drawing.Size(118, 29);
            this.genuddel.TabIndex = 5;
            this.genuddel.Text = "Genfordel nisser";
            this.genuddel.UseVisualStyleBackColor = false;
            this.genuddel.Visible = false;
            this.genuddel.Click += new System.EventHandler(this.genuddel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(140, 173);
            this.Controls.Add(this.genuddel);
            this.Controls.Add(this.MANGLER);
            this.Controls.Add(this.Fordel);
            this.Controls.Add(this.Glemt);
            this.Controls.Add(this.Navne);
            this.MinimumSize = new System.Drawing.Size(156, 39);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Nisser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Fordel;
        private System.Windows.Forms.ComboBox Navne;
        private System.Windows.Forms.Button Glemt;
        private System.Windows.Forms.Button MANGLER;
        private System.Windows.Forms.Button genuddel;
    }
}

