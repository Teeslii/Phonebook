
namespace Phonebook
{
    partial class NumberDelete
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlDelete = new System.Windows.Forms.Panel();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.lblSureQuery = new System.Windows.Forms.Label();
            this.lblNameSurname = new System.Windows.Forms.Label();
            this.txtNameSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(555, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter the name or surname of the person whose number you want to delete:";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSearch.Location = new System.Drawing.Point(422, 89);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(128, 35);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlDelete
            // 
            this.pnlDelete.Controls.Add(this.btnYes);
            this.pnlDelete.Controls.Add(this.btnNo);
            this.pnlDelete.Controls.Add(this.lblSureQuery);
            this.pnlDelete.Controls.Add(this.lblNameSurname);
            this.pnlDelete.Location = new System.Drawing.Point(29, 139);
            this.pnlDelete.Name = "pnlDelete";
            this.pnlDelete.Size = new System.Drawing.Size(622, 194);
            this.pnlDelete.TabIndex = 0;
            this.pnlDelete.Visible = false;
            // 
            // btnYes
            // 
            this.btnYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYes.Location = new System.Drawing.Point(295, 57);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(110, 42);
            this.btnYes.TabIndex = 5;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNo.Location = new System.Drawing.Point(469, 57);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(110, 42);
            this.btnNo.TabIndex = 4;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // lblSureQuery
            // 
            this.lblSureQuery.AutoSize = true;
            this.lblSureQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSureQuery.Location = new System.Drawing.Point(223, 15);
            this.lblSureQuery.Name = "lblSureQuery";
            this.lblSureQuery.Size = new System.Drawing.Size(383, 18);
            this.lblSureQuery.TabIndex = 2;
            this.lblSureQuery.Text = "is about to be deleted from the directory, do you confirm?";
            // 
            // lblNameSurname
            // 
            this.lblNameSurname.AutoSize = true;
            this.lblNameSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNameSurname.Location = new System.Drawing.Point(35, 15);
            this.lblNameSurname.Name = "lblNameSurname";
            this.lblNameSurname.Size = new System.Drawing.Size(0, 18);
            this.lblNameSurname.TabIndex = 1;
            // 
            // txtNameSurname
            // 
            this.txtNameSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNameSurname.Location = new System.Drawing.Point(195, 97);
            this.txtNameSurname.Name = "txtNameSurname";
            this.txtNameSurname.Size = new System.Drawing.Size(172, 22);
            this.txtNameSurname.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(32, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Name Surname";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack.Location = new System.Drawing.Point(640, 391);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(125, 33);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // NumberDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNameSurname);
            this.Controls.Add(this.pnlDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Name = "NumberDelete";
            this.Text = "Delete The Number";
            this.pnlDelete.ResumeLayout(false);
            this.pnlDelete.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnlDelete;
        private System.Windows.Forms.Label lblSureQuery;
        private System.Windows.Forms.Label lblNameSurname;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.TextBox txtNameSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBack;
    }
}