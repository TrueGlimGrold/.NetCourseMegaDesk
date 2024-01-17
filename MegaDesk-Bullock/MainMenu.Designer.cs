namespace MegaDesk_Bullock
{
    partial class MainMenu
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
            this.btnNavVeiw = new System.Windows.Forms.Button();
            this.btnNavSearch = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnNavAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNavVeiw
            // 
            this.btnNavVeiw.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnNavVeiw.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnNavVeiw.FlatAppearance.BorderSize = 3;
            this.btnNavVeiw.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnNavVeiw.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavVeiw.Location = new System.Drawing.Point(40, 137);
            this.btnNavVeiw.Margin = new System.Windows.Forms.Padding(5);
            this.btnNavVeiw.Name = "btnNavVeiw";
            this.btnNavVeiw.Size = new System.Drawing.Size(300, 80);
            this.btnNavVeiw.TabIndex = 2;
            this.btnNavVeiw.Text = "View Quotes";
            this.btnNavVeiw.UseVisualStyleBackColor = false;
            this.btnNavVeiw.Click += new System.EventHandler(this.btnNavVeiw_Click);
            // 
            // btnNavSearch
            // 
            this.btnNavSearch.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnNavSearch.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnNavSearch.FlatAppearance.BorderSize = 3;
            this.btnNavSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnNavSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavSearch.Location = new System.Drawing.Point(40, 227);
            this.btnNavSearch.Margin = new System.Windows.Forms.Padding(5);
            this.btnNavSearch.Name = "btnNavSearch";
            this.btnNavSearch.Size = new System.Drawing.Size(300, 80);
            this.btnNavSearch.TabIndex = 3;
            this.btnNavSearch.Text = "Search Quotes";
            this.btnNavSearch.UseVisualStyleBackColor = false;
            this.btnNavSearch.Click += new System.EventHandler(this.btnNavSearch_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button4.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button4.FlatAppearance.BorderSize = 3;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(40, 317);
            this.button4.Margin = new System.Windows.Forms.Padding(5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(300, 80);
            this.button4.TabIndex = 4;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnNavAdd
            // 
            this.btnNavAdd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnNavAdd.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnNavAdd.FlatAppearance.BorderSize = 3;
            this.btnNavAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnNavAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavAdd.Location = new System.Drawing.Point(40, 47);
            this.btnNavAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnNavAdd.Name = "btnNavAdd";
            this.btnNavAdd.Size = new System.Drawing.Size(300, 80);
            this.btnNavAdd.TabIndex = 1;
            this.btnNavAdd.Text = "Add New Quote";
            this.btnNavAdd.UseVisualStyleBackColor = false;
            this.btnNavAdd.Click += new System.EventHandler(this.btnNavAdd_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnNavSearch);
            this.Controls.Add(this.btnNavVeiw);
            this.Controls.Add(this.btnNavAdd);
            this.Name = "MainMenu";
            this.Text = "MegaDesk";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNavVeiw;
        private System.Windows.Forms.Button btnNavSearch;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnNavAdd;
    }
}

