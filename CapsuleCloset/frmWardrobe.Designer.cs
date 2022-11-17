
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
            this.txtShirts = new System.Windows.Forms.TextBox();
            this.lblShirts = new System.Windows.Forms.Label();
            this.txtPants = new System.Windows.Forms.TextBox();
            this.lblPants = new System.Windows.Forms.Label();
            this.txtJac = new System.Windows.Forms.TextBox();
            this.lblJac = new System.Windows.Forms.Label();
            this.lblAcc = new System.Windows.Forms.Label();
            this.txtAcc = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
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
            // txtShirts
            // 
            this.txtShirts.Location = new System.Drawing.Point(125, 175);
            this.txtShirts.Multiline = true;
            this.txtShirts.Name = "txtShirts";
            this.txtShirts.Size = new System.Drawing.Size(100, 250);
            this.txtShirts.TabIndex = 1;
            this.txtShirts.TextChanged += new System.EventHandler(this.txtShirts_TextChanged);
            // 
            // lblShirts
            // 
            this.lblShirts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShirts.Location = new System.Drawing.Point(125, 150);
            this.lblShirts.Name = "lblShirts";
            this.lblShirts.Size = new System.Drawing.Size(100, 25);
            this.lblShirts.TabIndex = 3;
            this.lblShirts.Text = "Shirts";
            this.lblShirts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPants
            // 
            this.txtPants.Location = new System.Drawing.Point(275, 175);
            this.txtPants.Multiline = true;
            this.txtPants.Name = "txtPants";
            this.txtPants.Size = new System.Drawing.Size(100, 250);
            this.txtPants.TabIndex = 5;
            this.txtPants.TextChanged += new System.EventHandler(this.txtPants_TextChanged);
            // 
            // lblPants
            // 
            this.lblPants.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPants.Location = new System.Drawing.Point(275, 150);
            this.lblPants.Name = "lblPants";
            this.lblPants.Size = new System.Drawing.Size(100, 25);
            this.lblPants.TabIndex = 7;
            this.lblPants.Text = "Pants";
            this.lblPants.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtJac
            // 
            this.txtJac.Location = new System.Drawing.Point(425, 175);
            this.txtJac.Multiline = true;
            this.txtJac.Name = "txtJac";
            this.txtJac.Size = new System.Drawing.Size(100, 250);
            this.txtJac.TabIndex = 8;
            this.txtJac.TextChanged += new System.EventHandler(this.txtJac_TextChanged);
            // 
            // lblJac
            // 
            this.lblJac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJac.Location = new System.Drawing.Point(425, 150);
            this.lblJac.Name = "lblJac";
            this.lblJac.Size = new System.Drawing.Size(100, 25);
            this.lblJac.TabIndex = 10;
            this.lblJac.Text = "Jackets";
            this.lblJac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAcc
            // 
            this.lblAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcc.Location = new System.Drawing.Point(575, 150);
            this.lblAcc.Name = "lblAcc";
            this.lblAcc.Size = new System.Drawing.Size(100, 25);
            this.lblAcc.TabIndex = 13;
            this.lblAcc.Text = "Accessories";
            this.lblAcc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAcc
            // 
            this.txtAcc.Location = new System.Drawing.Point(575, 175);
            this.txtAcc.Multiline = true;
            this.txtAcc.Name = "txtAcc";
            this.txtAcc.Size = new System.Drawing.Size(100, 250);
            this.txtAcc.TabIndex = 11;
            this.txtAcc.TextChanged += new System.EventHandler(this.txtAcc_TextChanged);
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
            // frmWardrobe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblAcc);
            this.Controls.Add(this.txtAcc);
            this.Controls.Add(this.lblJac);
            this.Controls.Add(this.txtJac);
            this.Controls.Add(this.lblPants);
            this.Controls.Add(this.txtPants);
            this.Controls.Add(this.lblShirts);
            this.Controls.Add(this.txtShirts);
            this.Controls.Add(this.labelWardrobe);
            this.Name = "frmWardrobe";
            this.Text = "frmWardrobe";
            this.Load += new System.EventHandler(this.frmWardrobe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWardrobe;
        private System.Windows.Forms.TextBox txtShirts;
        private System.Windows.Forms.Label lblShirts;
        private System.Windows.Forms.TextBox txtPants;
        private System.Windows.Forms.Label lblPants;
        private System.Windows.Forms.TextBox txtJac;
        private System.Windows.Forms.Label lblJac;
        private System.Windows.Forms.Label lblAcc;
        private System.Windows.Forms.TextBox txtAcc;
        private System.Windows.Forms.Button btnSave;
    }
}