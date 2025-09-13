using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoList.Models;

namespace ToDoList
{
    public partial class AddForm : Form
    {
        public event Action<TodoTask> OnTaskCreated;
        public AddForm()
        {
            InitializeComponent();
            priorityInput.Items.Clear();
            foreach (var value in Enum.GetValues(typeof(Data.TaskPriority)))
            {
                priorityInput.Items.Add(value);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AppDbContext appDbContext = new AppDbContext();
            if(priorityInput.SelectedItem is Data.TaskPriority selected)
            {
                if(nameInput.Text.Length == 0)
                {
                    MessageBox.Show("Error adding task: Empty task name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var task = new TodoTask(nameInput.Text, selected, deadlineInput.Value);
                appDbContext.TodoTasks.Add(task);
                appDbContext.SaveChanges();
                OnTaskCreated.Invoke(task);
            }
            else
            {
                MessageBox.Show("Error adding task: Invalid data in priority input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
