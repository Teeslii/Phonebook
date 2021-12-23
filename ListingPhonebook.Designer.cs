
namespace Phonebook
{
    partial class ListingPhonebook
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
            this.listViewPhonebook = new System.Windows.Forms.ListView();
            this.PersonId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewPhonebook
            // 
            this.listViewPhonebook.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PersonId,
            this.NameSurname,
            this.Number});
            this.listViewPhonebook.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listViewPhonebook.HideSelection = false;
            this.listViewPhonebook.Location = new System.Drawing.Point(37, 79);
            this.listViewPhonebook.Name = "listViewPhonebook";
            this.listViewPhonebook.Size = new System.Drawing.Size(441, 325);
            this.listViewPhonebook.TabIndex = 1;
            this.listViewPhonebook.UseCompatibleStateImageBehavior = false;
            this.listViewPhonebook.View = System.Windows.Forms.View.Details;
            // 
            // PersonId
            // 
            this.PersonId.Text = "Person ID";
            this.PersonId.Width = 89;
            // 
            // NameSurname
            // 
            this.NameSurname.Text = "Name Surname";
            this.NameSurname.Width = 164;
            // 
            // Number
            // 
            this.Number.Text = "Number";
            this.Number.Width = 181;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(34, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Phonebook :";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack.Location = new System.Drawing.Point(638, 384);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(125, 33);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ListingPhonebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewPhonebook);
            this.Name = "ListingPhonebook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listing Phonebook";
            this.Load += new System.EventHandler(this.ListingPhonebook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewPhonebook;
        private System.Windows.Forms.ColumnHeader PersonId;
        private System.Windows.Forms.ColumnHeader Number;
        public System.Windows.Forms.ColumnHeader NameSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
    }
}