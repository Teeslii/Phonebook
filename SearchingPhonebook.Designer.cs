
namespace Phonebook
{
    partial class SearchingPhonebook
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
            this.txtNameSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearchNameSurname = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnSearchNumber = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblPersonId = new System.Windows.Forms.Label();
            this.lblNameSurname = new System.Windows.Forms.Label();
            this.pnlResultFound = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlResultFound.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNameSurname
            // 
            this.txtNameSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNameSurname.Location = new System.Drawing.Point(256, 128);
            this.txtNameSurname.Name = "txtNameSurname";
            this.txtNameSurname.Size = new System.Drawing.Size(198, 29);
            this.txtNameSurname.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(106, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name Surname:";
            // 
            // btnSearchNameSurname
            // 
            this.btnSearchNameSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSearchNameSurname.Location = new System.Drawing.Point(512, 119);
            this.btnSearchNameSurname.Name = "btnSearchNameSurname";
            this.btnSearchNameSurname.Size = new System.Drawing.Size(133, 38);
            this.btnSearchNameSurname.TabIndex = 7;
            this.btnSearchNameSurname.Text = "Search";
            this.btnSearchNameSurname.UseVisualStyleBackColor = true;
            this.btnSearchNameSurname.Click += new System.EventHandler(this.btnSearchNameSurname_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(84, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(561, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Please enter the name or surname of the person whose number you want to search:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(84, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Please enter the number of the person whose find you want to search:\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(106, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Number :";
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtNumber.Location = new System.Drawing.Point(256, 250);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(198, 29);
            this.txtNumber.TabIndex = 13;
            // 
            // btnSearchNumber
            // 
            this.btnSearchNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSearchNumber.Location = new System.Drawing.Point(512, 241);
            this.btnSearchNumber.Name = "btnSearchNumber";
            this.btnSearchNumber.Size = new System.Drawing.Size(133, 38);
            this.btnSearchNumber.TabIndex = 14;
            this.btnSearchNumber.Text = "Search";
            this.btnSearchNumber.UseVisualStyleBackColor = true;
            this.btnSearchNumber.Click += new System.EventHandler(this.btnSearchNumber_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(19, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(267, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "The person and number you are calling:";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNumber.Location = new System.Drawing.Point(399, 57);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(0, 18);
            this.lblNumber.TabIndex = 16;
            // 
            // lblPersonId
            // 
            this.lblPersonId.AutoSize = true;
            this.lblPersonId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonId.Location = new System.Drawing.Point(41, 57);
            this.lblPersonId.Name = "lblPersonId";
            this.lblPersonId.Size = new System.Drawing.Size(0, 18);
            this.lblPersonId.TabIndex = 17;
            // 
            // lblNameSurname
            // 
            this.lblNameSurname.AutoSize = true;
            this.lblNameSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNameSurname.Location = new System.Drawing.Point(208, 57);
            this.lblNameSurname.Name = "lblNameSurname";
            this.lblNameSurname.Size = new System.Drawing.Size(0, 18);
            this.lblNameSurname.TabIndex = 18;
            // 
            // pnlResultFound
            // 
            this.pnlResultFound.Controls.Add(this.label5);
            this.pnlResultFound.Controls.Add(this.lblNumber);
            this.pnlResultFound.Controls.Add(this.lblNameSurname);
            this.pnlResultFound.Controls.Add(this.lblPersonId);
            this.pnlResultFound.Location = new System.Drawing.Point(65, 336);
            this.pnlResultFound.Name = "pnlResultFound";
            this.pnlResultFound.Size = new System.Drawing.Size(599, 100);
            this.pnlResultFound.TabIndex = 19;
            this.pnlResultFound.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack.Location = new System.Drawing.Point(636, 393);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(125, 33);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // SearchingPhonebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlResultFound);
            this.Controls.Add(this.btnSearchNumber);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSearchNameSurname);
            this.Controls.Add(this.txtNameSurname);
            this.Controls.Add(this.label2);
            this.Name = "SearchingPhonebook";
            this.Text = "Searching Phonebook";
            this.pnlResultFound.ResumeLayout(false);
            this.pnlResultFound.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNameSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearchNameSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnSearchNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblPersonId;
        private System.Windows.Forms.Label lblNameSurname;
        private System.Windows.Forms.Panel pnlResultFound;
        private System.Windows.Forms.Button btnBack;
    }
}