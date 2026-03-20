using dpiotrowski_lab1.Presenters;
using dpiotrowski_lab1.Views;

namespace dpiotrowski_lab1
{
    public partial class StudentForm : Form, IAddStudentView
    {
        public event EventHandler<StudentData> AddNewStudent;
        public event EventHandler<IDStudentData> UpdateStudent;
        public event EventHandler<Guid> DropStudent;

        public event EventHandler<StudentData> LoadStudent;
        public event EventHandler<string> SaveStudentListToFile;
        public event EventHandler<string> LoadStudentListFromFile;

        private OpenFileDialog _fileDialog = new();

        private Guid? _selectedStudent = null;

        private StudentPresenter _presenter;

        public StudentForm()
        {
            InitializeComponent();

            this.addStudentButton.Click += AddStudentButton_Click;
            this.editStudentButton.Click += editStudentButton_Click;
            this.dropStudentButton.Click += dropStudentButton_Click;

            this._presenter = new StudentPresenter(this, null, new Models.StudentRegister());
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

            if (studentData.FlatNumber != null)
            {
                flatInput.Text = studentData.FlatNumber;
                flatInput.Enabled = true;
                flatInputCheckBox.Checked = true;
            }
            else
            {
                flatInput.Text = "";
                flatInput.Enabled = false;
                flatInputCheckBox.Checked = false;
            }
        }

        public void ShowMessage(String message)
        {
            MessageBox.Show(message);
        }

        public void UpdateStudentList(List<StudentData> students)
        {
            studentList.Items.Clear();

            foreach (StudentData student in students)
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
            flatInput.Enabled= false;
        }

        public void AddStudentButton_Click(object? sender, EventArgs e)
        {
            StudentData newStudent = new StudentData(
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

            AddNewStudent.Invoke(this, newStudent);

            _clearStudentForm();

            this._selectedStudent = null;
        }

        private void flatInputCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            flatInput.Enabled = flatInputCheckBox.Enabled;
        }

        private void editStudentButton_Click(object? sender, EventArgs e)
        {
            if (!this._selectedStudent.HasValue)
            {
                ShowMessage("Nie wybrano studenta do edycji!");
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

            UpdateStudent.Invoke(this, editedStudent);

            _clearStudentForm();

            this._selectedStudent = null;
        }

        private void dropStudentButton_Click(object? sender, EventArgs e)
        {
            if (!this._selectedStudent.HasValue)
            {
                ShowMessage("Nie wybrano studenta do edycji!");
                return;
            }

            DropStudent.Invoke(this, this._selectedStudent.Value);

            this._clearStudentForm();

            this._selectedStudent = null;
        }
    }
}
