using dpiotrowski_lab1.Presenters;
using dpiotrowski_lab1.Views;

namespace dpiotrowski_lab1
{
    public partial class StudentForm : Form, IAddStudentView, IStudentListView
    {

        private Guid? _selectedStudent = null;

        private IStudentPresenter _presenter;

        public StudentForm()
        {
            InitializeComponent();

            this.addStudentButton.Click += AddStudentButton_Click;
            this.editStudentButton.Click += editStudentButton_Click;
            this.dropStudentButton.Click += dropStudentButton_Click;

            this._presenter = new StudentPresenter(this, this, new Models.StudentRegister());

            this.flatInputCheckBox_CheckedChanged(null, null);
        }

        public void LoadStudentIntoForm(StudentData studentData)
        {
            nameInput.Text = studentData.Name;
            lastNameInput.Text = studentData.LastName;
            dateOfBirthInput.Value = studentData.DateOfBirth;
            yearOfStudyInput.SelectedValue = studentData;

            cityInput.Text = studentData.Street;
            postalCodeInput1.Text = studentData.PostalCodeFirst;
            postalCodeInput2.Text = studentData.PostalCodeSecond;
            streetInput.Text = studentData.Street;
            buildingInput.Text = studentData.BuildingNumber;

            if (studentData.FlatNumber != "")
            {
                flatInput.Text = studentData.FlatNumber;
                flatInputCheckBox.Checked = true;
            }
            else
            {
                flatInput.Text = "";
                flatInputCheckBox.Checked = false;
            }

            this.flatInputCheckBox_CheckedChanged(null, null);
        }

        private void _showMessage(String message)
        {
            MessageBox.Show(message);
        }

        public void UpdateStudentList(IEnumerable<IDStudentData> students)
        {
            studentList.Items.Clear();

            foreach (IDStudentData student in students)
            {
                studentList.Items.Add(student);
            }
        }

        private void _clearStudentForm()
        {
            nameInput.Text = "";
            lastNameInput.Text = "";
            dateOfBirthInput.Value = DateTime.Now;
            yearOfStudyInput.SelectedValue = null;
            cityInput.Text = "";
            postalCodeInput1.Text = "";
            postalCodeInput2.Text = "";
            streetInput.Text = "";
            buildingInput.Text = "";
            flatInputCheckBox.Checked = false;
            flatInput.Text = "";
            flatInput.Enabled = false;
        }

        public void AddStudentButton_Click(object? sender, EventArgs e)
        {
            string yearOfStudy = yearOfStudyInput.SelectedItem == null ? "" : (string)yearOfStudyInput.SelectedItem;

            StudentData newStudent = new StudentData(
                nameInput.Text,
                lastNameInput.Text,
                dateOfBirthInput.Value,
                yearOfStudy,
                cityInput.Text,
                postalCodeInput1.Text,
                postalCodeInput2.Text,
                streetInput.Text,
                buildingInput.Text,
                flatInputCheckBox.Checked ? flatInput.Text : null
            );

            try
            {
                this._presenter.AddStudent(newStudent);

                _clearStudentForm();

                this._selectedStudent = null;
            }
            catch (ArgumentException exception)
            {
                _showMessage(exception.Message);
            }
        }

        private void _allowDigits(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void _allowLettersAndWhitespace(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void _allowAlphanumeric(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void flatInputCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            flatInput.Enabled = flatInputCheckBox.Checked;
            flatInput.Visible = flatInputCheckBox.Checked;
        }

        private void editStudentButton_Click(object? sender, EventArgs e)
        {
            if (!this._selectedStudent.HasValue)
            {
                _showMessage("Nie wybrano studenta do edycji!");
                return;
            }

            IDStudentData editedStudent = new IDStudentData(
                this._selectedStudent.Value,
                nameInput.Text,
                lastNameInput.Text,
                dateOfBirthInput.Value,
                yearOfStudyInput.SelectedValue == null ? "" : (string)yearOfStudyInput.SelectedValue,
                cityInput.Text,
                postalCodeInput1.Text,
                postalCodeInput2.Text,
                streetInput.Text,
                buildingInput.Text,
                flatInputCheckBox.Checked ? flatInput.Text : null
            );

            try
            {
                this._presenter.UpdateStudent(editedStudent);

                _clearStudentForm();

                this._selectedStudent = null;
            }
            catch (ArgumentException exception)
            {
                _showMessage(exception.Message);
            }
        }

        private void dropStudentButton_Click(object? sender, EventArgs e)
        {
            if (!this._selectedStudent.HasValue)
            {
                _showMessage("Nie wybrano studenta do edycji!");
                return;
            }

            this._presenter.DropStudent(this._selectedStudent.Value);

            this._clearStudentForm();

            this._selectedStudent = null;
        }

        private void _studentListSelectedItemChanged(object? sender, EventArgs e)
        {
            if (this.studentList != null && this.studentList.SelectedItems.Count > 0)
            {
                this._selectedStudent = ((IDStudentData)this.studentList.SelectedItems[0]).Id;

                this._presenter.LoadStudentToForm(this._selectedStudent.Value);
            }
        }

        private void saveStudentListButton_Click(object sender, EventArgs e)
        {
            DialogResult result = this.saveStudentsToFileDialog.ShowDialog();

            if(result == DialogResult.OK)
            {
                try
                {
                    this._presenter.SaveStudentListToFile(this.saveStudentsToFileDialog.FileName);
                }
                catch(FileNotFoundException)
                {
                    this._showMessage($"Nie uda³o siê otworzyæ pliku {this.saveStudentsToFileDialog.FileName}");
                }
            }
        }
    }
}
