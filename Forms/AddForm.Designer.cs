namespace ToDoList
{
    partial class AddForm
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
            nameLabel = new Label();
            nameInput = new TextBox();
            deadlineLabel = new Label();
            priorityLabel = new Label();
            deadlineInput = new DateTimePicker();
            priorityInput = new ComboBox();
            addBtn = new Button();
            cancelBtn = new Button();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nameLabel.Location = new Point(66, 28);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(88, 37);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name";
            // 
            // nameInput
            // 
            nameInput.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nameInput.Location = new Point(188, 28);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(238, 43);
            nameInput.TabIndex = 1;
            // 
            // deadlineLabel
            // 
            deadlineLabel.AutoSize = true;
            deadlineLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            deadlineLabel.Location = new Point(31, 160);
            deadlineLabel.Name = "deadlineLabel";
            deadlineLabel.Size = new Size(123, 37);
            deadlineLabel.TabIndex = 2;
            deadlineLabel.Text = "Deadline";
            // 
            // priorityLabel
            // 
            priorityLabel.AutoSize = true;
            priorityLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            priorityLabel.Location = new Point(52, 95);
            priorityLabel.Name = "priorityLabel";
            priorityLabel.Size = new Size(102, 37);
            priorityLabel.TabIndex = 3;
            priorityLabel.Text = "Priority";
            // 
            // deadlineInput
            // 
            deadlineInput.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            deadlineInput.Location = new Point(188, 160);
            deadlineInput.Name = "deadlineInput";
            deadlineInput.Size = new Size(287, 43);
            deadlineInput.TabIndex = 4;
            // 
            // priorityInput
            // 
            priorityInput.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            priorityInput.FormattingEnabled = true;
            priorityInput.Items.AddRange(new object[] { "urgent", "neccessary", "unneccessary" });
            priorityInput.Location = new Point(188, 95);
            priorityInput.Name = "priorityInput";
            priorityInput.Size = new Size(238, 45);
            priorityInput.TabIndex = 5;
            // 
            // addBtn
            // 
            addBtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addBtn.Location = new Point(88, 243);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(123, 45);
            addBtn.TabIndex = 6;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cancelBtn.Location = new Point(253, 243);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(123, 45);
            cancelBtn.TabIndex = 7;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 306);
            Controls.Add(cancelBtn);
            Controls.Add(addBtn);
            Controls.Add(priorityInput);
            Controls.Add(deadlineInput);
            Controls.Add(priorityLabel);
            Controls.Add(deadlineLabel);
            Controls.Add(nameInput);
            Controls.Add(nameLabel);
            Name = "AddForm";
            Text = "Add Task";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private TextBox nameInput;
        private Label deadlineLabel;
        private Label priorityLabel;
        private DateTimePicker deadlineInput;
        private ComboBox priorityInput;
        private Button addBtn;
        private Button cancelBtn;
    }
}