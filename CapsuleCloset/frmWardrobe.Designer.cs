
namespace CapsuleCloset
{
    partial class frmWardrobe
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
            this.labelWardrobe = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgShirts = new System.Windows.Forms.DataGridView();
            this.dgPants = new System.Windows.Forms.DataGridView();
            this.dgJackets = new System.Windows.Forms.DataGridView();
            this.dgAccessories = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgShirts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgJackets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccessories)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWardrobe
            // 
            this.labelWardrobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWardrobe.Location = new System.Drawing.Point(250, 50);
            this.labelWardrobe.Name = "labelWardrobe";
            this.labelWardrobe.Size = new System.Drawing.Size(300, 50);
            this.labelWardrobe.TabIndex = 0;
            this.labelWardrobe.Text = "Wardrobe";
            this.labelWardrobe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(350, 475);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 25);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save Wardrobe";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgShirts
            // 
            this.dgShirts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgShirts.Location = new System.Drawing.Point(51, 132);
            this.dgShirts.Name = "dgShirts";
            this.dgShirts.Size = new System.Drawing.Size(148, 250);
            this.dgShirts.TabIndex = 15;
            // 
            // dgPants
            // 
            this.dgPants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPants.Location = new System.Drawing.Point(225, 135);
            this.dgPants.Name = "dgPants";
            this.dgPants.Size = new System.Drawing.Size(148, 250);
            this.dgPants.TabIndex = 16;
            // 
            // dgJackets
            // 
            this.dgJackets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgJackets.Location = new System.Drawing.Point(403, 135);
            this.dgJackets.Name = "dgJackets";
            this.dgJackets.Size = new System.Drawing.Size(148, 250);
            this.dgJackets.TabIndex = 17;
            // 
            // dgAccessories
            // 
            this.dgAccessories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAccessories.Location = new System.Drawing.Point(581, 135);
            this.dgAccessories.Name = "dgAccessories";
            this.dgAccessories.Size = new System.Drawing.Size(148, 250);
            this.dgAccessories.TabIndex = 18;
            // 
            // frmWardrobe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dgAccessories);
            this.Controls.Add(this.dgJackets);
            this.Controls.Add(this.dgPants);
            this.Controls.Add(this.dgShirts);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelWardrobe);
            this.Name = "frmWardrobe";
            this.Text = "frmWardrobe";
            this.Load += new System.EventHandler(this.frmWardrobe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgShirts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgJackets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccessories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelWardrobe;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgShirts;
        private System.Windows.Forms.DataGridView dgPants;
        private System.Windows.Forms.DataGridView dgJackets;
        private System.Windows.Forms.DataGridView dgAccessories;
    }
}