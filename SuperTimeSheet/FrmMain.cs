using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using SuperTimeSheet.Classes;

namespace SuperTimeSheet
{
    public partial class FrmMain : Form
    {
        // Total amount of hours per day for all tasks (Time Sheet summary value)
        private double totalTasksDurationInHours;

        // Timstamp for start time for task
        private DateTime taskStartTime;

        // 
        private bool isTimerStarted = false;

        private TimeSpan taskDurationTimeSpan;

        // Indicates that user added/changed some data while session and Save dialog must be shown before app exit
        private bool isDataChanged;

        // If data was saved to file or opened from file - holds current data file name
        private string currentFileName;

        private Dictionary<string, string> settings = new Dictionary<string, string>();

        private List<ProjectPrefix> projectPrefixes = new List<ProjectPrefix>();

        public const string SETTINGS_KEY_LAST_FILE_NAME = "LastFileName";
        public const string SETTINGS_KEY_PROJECTS = "Projects";
        public const string SETTINGS_KEY_PREFIXES = "Prefixes";

        public const string DEFAULT_FILENAME_POSTFIX = "_SuperTimeSheet.supts";

        //public const int COLUMN_INDEX_TASK_DATE = 0;
        //public const int COLUMN_INDEX_TASK_NAME = 1;
        //public const int COLUMN_INDEX_TASK_DURATION = 2;
        //public const int COLUMN_INDEX_TASK_PROJECT = 3;

        public double TotalTasksDurationInHours
        {
            get { return totalTasksDurationInHours; }
            set { totalTasksDurationInHours = value; }
        }

        public bool IsDataChanged
        {
            get { return isDataChanged; }
            set { isDataChanged = value; }
        }

        public string CurrentFileName
        {
            get { return currentFileName; }
            set { currentFileName = value; }
        }

        public FrmMain()
        {
            InitializeComponent();
        }

        DataGridViewRow GetNewRowForGrid(string taskDate, string taskName, string taskDuration, String taskProject)
        {
            DataGridViewRow newTaskRow = new DataGridViewRow();

            DataGridViewTextBoxCell cellNewTaskDate = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell cellNewTaskName = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell cellNewTaskDuration = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell cellNewTaskProject = new DataGridViewTextBoxCell();

            cellNewTaskDate.Value = taskDate;            
            cellNewTaskName.Value = taskName;            
            cellNewTaskDuration.Value = taskDuration;            
            cellNewTaskProject.Value = taskProject;

            if (NumberUtilities.IsValidDouble(taskDuration))
            {
                GridCellUtilities.SetCellValidStyle(cellNewTaskDuration);
            }
            else
            {
                GridCellUtilities.SetCellInvalidStyle(cellNewTaskDuration);
            }

            newTaskRow.Cells.Add(cellNewTaskDate);
            newTaskRow.Cells.Add(cellNewTaskName);
            newTaskRow.Cells.Add(cellNewTaskDuration);
            newTaskRow.Cells.Add(cellNewTaskProject);

            return newTaskRow;
        }

        /// <summary>
        /// Returns the new instance of DataGridViewRow for futher adding
        /// </summary>
        /// <param name="taskDate">The date of the task</param>
        /// <param name="taskName">The name (title) of the task</param>
        /// <param name="taskDuration">The task duration</param>
        /// <returns></returns>
        private DataGridViewRow GetNewRowForGrid(string taskDate, string taskName, string taskDuration)
        {
            return GetNewRowForGrid(taskDate, taskName, taskDuration, "");
        }

        private string GetTaskNameWithPrefix()
        {
            string prefix = (string)cboTaskPrefix.SelectedItem;
            string taskName;
            if ("<без префикса>".Equals(prefix) || prefix == null)
            {
                taskName = txtTaskName.Text;
            }
            else
            {
                taskName = prefix + ". " + txtTaskName.Text;
            }
            return taskName;
        }

        private DataGridViewRow GetNewRowForAdding()
        {

            string taskName = GetTaskNameWithPrefix();
            string taskDate = dtTaskDate.Value.ToShortDateString();
            string taskDuration;

            try
            {
                String inputTaskDuration = txtTaskDuration.Text;
                inputTaskDuration = inputTaskDuration.Replace(".", ",");
                txtTaskDuration.Text = inputTaskDuration;

                double taskDurationInHours = Convert.ToDouble(inputTaskDuration);
                if (radioDurationMinutes.Checked)
                {
                    taskDurationInHours = taskDurationInHours / 60;
                }

                //cellNewTaskDuration.Value = Convert.ToString(taskDurationInHours);
                taskDuration = Convert.ToString(taskDurationInHours);

                TotalTasksDurationInHours += taskDurationInHours;
            }
            catch (FormatException exception)
            {
                MessageBox.Show("Ошибка при вводе: длительность задачи должна быть целым или дробным числом.\r\nПримеры корректного ввода длительности: 1; 1.5; 3,5; 0.5 и т.д.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            DataGridViewRow newTaskRow;

            string project = (string)cboProject.SelectedItem;
            if (project != null)
            {
                newTaskRow = GetNewRowForGrid(taskDate, taskName, taskDuration, project);
            }
            else
            {
                newTaskRow = GetNewRowForGrid(taskDate, taskName, taskDuration);
            }

            
            //newTaskRow.Cells.Add(cellNewTaskDuration);
            newTaskRow.Tag = txtTaskName.Text;

            return newTaskRow;
        }

        private void RefreshTotalDuration()
        {
            DataGridViewRowCollection rows = gridTasks.Rows;
            if (rows == null || rows.Count == 0)
            {
                lblTotalDuration.Text = "0";
                return;
            }

            double totalDuration = 0.0d;

            foreach (DataGridViewRow row in rows)
            {
                if (row.IsNewRow)
                {
                    continue;
                }

                DataGridViewCellCollection cells = row.Cells;
                if (cells == null && cells.Count == 0)
                {
                    continue;
                }

                DataGridViewCell cellDuration = cells[GridColumnIndexes.COLUMN_INDEX_TASK_DURATION];
                double duration = 0.0d;
                try
                {
                    duration = Convert.ToDouble(cellDuration.Value);
                }
                catch (System.FormatException fmtException)
                {
                }
                totalDuration += duration;

            }

            TotalTasksDurationInHours = totalDuration;
            if (totalDuration < 4)
            {
                lblTotalDuration.ForeColor = Color.Red;
            }
            else if (totalDuration >= 4 && totalDuration < 8)
            {
                lblTotalDuration.ForeColor = Color.Orange;
            }
            else if (totalDuration >= 8)
            {
                lblTotalDuration.ForeColor = Color.DarkGreen;
            }
            lblTotalDuration.Text = TotalTasksDurationInHours.ToString();
        }



        //private string GetFullTaskNameWithPrefix()
        //{

        //}

        private void UpdateTaskFromControls()
        {
            //DataGridViewSelectedRowCollection colSelectedRows = gridTasks.SelectedRows;
            //if (colSelectedRows.Count > 0)
            //{
            //    DataGridViewRow selectedRow = colSelectedRows[0];        
            //    if (!selectedRow.IsNewRow)
            //    {
            //        selectedRow.Cells[0].Value = 
            //    }
            //}
        }


        /// <summary>
        /// Gets the selected row in grid or null if no row selected
        /// </summary>
        /// <returns>DataGridViewRow object for selected row or null if no row selected</returns>
        private DataGridViewRow GetSelectedRow()
        {
            DataGridViewRow selectedRow = null;
            DataGridViewSelectedRowCollection colSelectedRows = gridTasks.SelectedRows;
            if (colSelectedRows.Count == 1)
            {
                selectedRow = colSelectedRows[0];
            }
            return selectedRow;
        }

        private TimeSheetTask GetSelectedTask()
        {
            TimeSheetTask result = null;

            DataGridViewRow selectedRow = GetSelectedRow();
            
            if (selectedRow != null)
            {
                if (!selectedRow.IsNewRow)
                {
                    string taskDate = GridRowUtilities.GetTaskDateFromGridRow(selectedRow);
                    string taskName = GridRowUtilities.GetTaskNameFromGridRow(selectedRow);
                    string taskDuration = GridRowUtilities.GetTaskDurationFromGridRow(selectedRow);
                    string taskProject = GridRowUtilities.GetTaskProjectFromGridRow(selectedRow);

                    result = new TimeSheetTask();
                    result.TaskStringDate = taskDate;
                    result.TaskName = taskName;
                    result.TaskDuration = taskDuration;
                    result.TaskProject = taskProject;
                }
            }

            return result;
        }

        private void BtnUpdateTask_Click(object sender, EventArgs e)
        {
            //TimeSheetTask selectedTask = GetSelectedTask();
            DataGridViewRow selectedRow = GetSelectedRow();
            if (selectedRow != null)
            {
                selectedRow.Cells[GridColumnIndexes.COLUMN_INDEX_TASK_DATE].Value = dtTaskDate.Value.ToShortDateString();
                selectedRow.Cells[GridColumnIndexes.COLUMN_INDEX_TASK_NAME].Value = GetTaskNameWithPrefix();
                selectedRow.Cells[GridColumnIndexes.COLUMN_INDEX_TASK_DURATION].Value = txtTaskDuration.Text;
                selectedRow.Cells[GridColumnIndexes.COLUMN_INDEX_TASK_PROJECT].Value = (string)cboProject.SelectedItem;

            }

            //MessageBox.Show("Здесь идёт сообщение");
        }

        private void BtnAddTask_Click(object sender, EventArgs e)
        {
            DataGridViewRow newRow = GetNewRowForAdding();
            if (newRow != null)
            {
                gridTasks.Rows.Add(newRow);
                IsDataChanged = true;
                RefreshTotalDuration();
                ClearInputControls();
            }
        }

        /// <summary>
        /// Clears all input controls for the new task
        /// </summary>
        private void ClearInputControls()
        {
            txtTaskName.Text = "";
            txtTaskDuration.Text = "";
            txtPrefixDescription.Text = "";
            cboProject.SelectedItem = null;
            cboTaskPrefix.SelectedItem = null;            
        }

        private string GetSettingsFullFilePath()
        {
            string settingsFileName = "SuperTimeSheet.settings";
            string filePath = Application.ExecutablePath;
            int lastSlashPos = filePath.LastIndexOf("\\");
            string filePathWithoutExe = filePath.Remove(lastSlashPos);
            string settingsFullPath = filePathWithoutExe + "\\" + settingsFileName;
            return settingsFullPath;
        }
        private void SaveSettings()
        {
            string settingsFullPath = GetSettingsFullFilePath();
            Dictionary<string, string>.Enumerator enumerator = settings.GetEnumerator();

            string resultSettingsString = "";
            while (enumerator.MoveNext())
            {
                KeyValuePair<string, string> keyValPair = enumerator.Current;

                if (resultSettingsString.Length > 0)
                {
                    resultSettingsString += "\r\n";
                }
                
                string key = keyValPair.Key;
                string val = keyValPair.Value;

                resultSettingsString += key + "=" + val;

            } 

            File.WriteAllText(settingsFullPath, resultSettingsString);
        }


        private void ActivateSettings()
        {
            Dictionary<string, string>.Enumerator enumerator = settings.GetEnumerator();
            string[] projects = null;
            string[] prefixes = null;


            while (enumerator.MoveNext())
            {
                KeyValuePair<string, string> keyValPair = enumerator.Current;
                string key = keyValPair.Key;
                string val = keyValPair.Value;

                if (SETTINGS_KEY_LAST_FILE_NAME.Equals(key))
                {
                    if (!"".Equals(val))
                    {
                        ReadDataFromFile(val, true);
                    }                    
                }
                else if (SETTINGS_KEY_PROJECTS.Equals(key))
                {
                    projects = val.Split(',');
                    if (projects != null)
                    {
                        cboProject.Items.AddRange(projects);
                    } 
                }
                else if (SETTINGS_KEY_PREFIXES.Equals(key))
                {
                    prefixes = val.Split('|');
                    if (prefixes != null)
                    {
                        foreach (string prefix in prefixes)
                        {
                            string[] prefixData = prefix.Split('$');
                            if (prefixData != null && prefixData.Length == 2)
                            {
                                string prefixName = prefixData[0];
                                string prefixDesc = prefixData[1];
                                ProjectPrefix projectPrefix = new ProjectPrefix(prefixName, prefixDesc);

                                projectPrefixes.Add(projectPrefix);
                                cboTaskPrefix.Items.Add(prefixName);
                            }                            
                        }

                        ProjectPrefix projNoPrefix = new ProjectPrefix("<без префикса>", "префикс отсутствует");
                        projectPrefixes.Add(projNoPrefix);
                        cboTaskPrefix.Items.Add(projNoPrefix.Prefix);

                    }
                }
            }

            //if (projects == null)
            //{
            //    cboProject.Items.Add("Развитие. Команда Alpha");
            //    cboProject.Items.Add("Развитие. Команда Beta");
            //}

            //if (prefixes == null)
            //{
            //    cboTaskPrefix.Items.Add("ДЕЖ");
            //    cboTaskPrefix.Items.Add("ПЛАН");
            //}
        }

        private void LoadSettings()
        {
            string settingsFullPath = GetSettingsFullFilePath();
            string[] allSettingsLines = File.ReadAllLines(settingsFullPath);

            settings.Clear();

            if (allSettingsLines != null && allSettingsLines.Length > 0)
            {
                foreach (string settingsLine in allSettingsLines)
                {
                    string[] settingsLineKeyValPair = settingsLine.Split('=');
                    if (settingsLineKeyValPair != null && settingsLineKeyValPair.Length == 2)
                    {
                        // ok, parsed key & value pair
                        string key = settingsLineKeyValPair[0];
                        string value = settingsLineKeyValPair[1];

                        settings.Add(key, value);
                    }
                }
            }

            ActivateSettings();
            //MessageBox.Show(filePathWithoutExe);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadSettings();
            btnRemoveSelected.Enabled = false;
            lblTotalDuration.ForeColor = Color.Red;
            RefreshDialogTitle();
            RefreshTotalDuration();
        }

        private void GridTasks_SelectionChanged(object sender, EventArgs e)
        {
            if (gridTasks.IsCurrentCellInEditMode)
            {
                return;
            }

            DataGridViewSelectedRowCollection selectedRowsCollection = gridTasks.SelectedRows;
            if (selectedRowsCollection == null)
            {
                return;
            }
            
            if (selectedRowsCollection.Count > 0)
            {
                DataGridViewRow selectedRow = selectedRowsCollection[0];
                bool isNewRow = selectedRow.IsNewRow;

                if (isNewRow)
                {
                    btnRemoveSelected.Enabled = false;

                    txtTaskDuration.Text = "";
                    txtTaskName.Text = "";
                    dtTaskDate.Value = DateTime.Now;
                    cboProject.SelectedItem = null;
                    cboTaskPrefix.SelectedItem = null;
                    txtPrefixDescription.Text = "";

                    return;
                }


                if (gridTasks.Rows.Count == 1)
                {
                    btnRemoveSelected.Enabled = false;
                    return;
                }

                btnRemoveSelected.Enabled = (gridTasks.SelectedRows != null);

                DateTime selectedTaskDate;
                if (selectedRow.Cells[0].Value != null)
                {
                    selectedTaskDate = DateTime.Parse((string)selectedRow.Cells[0].Value);
                } else
                {
                    selectedTaskDate = DateTime.Now;
                }
                
                string selectedTaskName = (string)selectedRow.Cells[1].Value;
                string selectedTaskDuration = (string)selectedRow.Cells[2].Value;
                string selectedTaskProject = (string)selectedRow.Cells[3].Value;

                if (selectedTaskName != null && !"".Equals(selectedTaskName))
                {
                    int posDot = selectedTaskName.IndexOf(".");
                    if (posDot >= 0)
                    {
                        string prefix = selectedTaskName.Substring(0, posDot);
                        if (prefix != null)
                        {
                            bool prefixFound = false;
                            foreach (ProjectPrefix pref in projectPrefixes)
                            {
                                if (prefix.Equals(pref.Prefix))
                                {
                                    cboTaskPrefix.SelectedItem = prefix;
                                    txtPrefixDescription.Text = pref.Description;
                                    prefixFound = true;
                                    break;
                                }
                            }

                            if (!prefixFound)
                            {
                                cboTaskPrefix.SelectedItem = null;
                                txtPrefixDescription.Text = "";
                            }
                        }
                    } else
                    {
                        cboTaskPrefix.SelectedItem = null;
                        txtPrefixDescription.Text = "";
                    }
                }

                txtTaskDuration.Text = selectedTaskDuration;
                txtTaskName.Text = selectedTaskName;
                dtTaskDate.Value = selectedTaskDate;
                if (selectedTaskProject != null && !"".Equals(selectedTaskProject)) {
                    cboProject.SelectedItem = selectedTaskProject;
                } else
                {
                    cboProject.SelectedItem = null;
                }
            }            
        }

        private void BtnRemoveSelected_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRowsCollection = gridTasks.SelectedRows;
            foreach (DataGridViewRow row in selectedRowsCollection)
            {
                if (row.IsNewRow)
                {
                    continue;
                }                
                gridTasks.Rows.Remove(row);
                IsDataChanged = true;
            }
            RefreshTotalDuration();            
        }

        private void GridTasks_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            int columnIndex = e.ColumnIndex;
            int rowIndex = e.RowIndex;

            if (columnIndex == 0)
            {
                DataGridViewSelectedCellCollection selectedCells = gridTasks.SelectedCells;
                if (selectedCells.Count > 0)
                {
                    DataGridViewCell selectedCell = selectedCells[0];
                    if ("".Equals(selectedCell.Value) || selectedCell.Value == null)
                    {
                        selectedCell.Value = DateTime.Now.ToShortDateString();
                    }                    
                }
            }
            //MessageBox.Show("ColIndex = " + columnIndex.ToString() + ", RowIndex = " + rowIndex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }





        private void GridTasks_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {                
                RefreshTotalDuration();

                DataGridViewCell cell = gridTasks[e.ColumnIndex, e.RowIndex];
                string cellValue = (string)cell.Value;

                if (NumberUtilities.IsValidDouble(cellValue))
                {
                    GridCellUtilities.SetCellValidStyle(cell);
                } else
                {
                    GridCellUtilities.SetCellInvalidStyle(cell);                    
                }
            }
        }

        private void MnuMainMenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }        

        private void ReadDataFromFile(string fileName, bool settingsLoadMode)
        {
            if (FileUtilities.CheckFileNameAndShowErrorIfNull(fileName))
            {
                return;
            }

            string[] fileLines = File.ReadAllLines(fileName);
            if (fileLines != null && fileLines.Length > 0)
            {
                foreach (string fileLine in fileLines)
                {
                    string[] cellData = fileLine.Split('|');

                    string taskDate = "";
                    string taskName = "";
                    string taskDuration = "";
                    string taskProject = "";

                    // Old format for files - without project specification
                    if (cellData != null && cellData.Length >= 3 && cellData.Length <= 4)
                    {
                        // ok, all cells present
                        taskDate = cellData[GridColumnIndexes.COLUMN_INDEX_TASK_DATE];
                        taskName = cellData[GridColumnIndexes.COLUMN_INDEX_TASK_NAME];
                        taskDuration = cellData[GridColumnIndexes.COLUMN_INDEX_TASK_DURATION];
                    }
                    if (cellData != null && cellData.Length == 4)
                    {
                        taskProject = cellData[GridColumnIndexes.COLUMN_INDEX_TASK_PROJECT];
                    }

                    DataGridViewRow newRow = GetNewRowForGrid(taskDate, taskName, taskDuration);
                    newRow.Tag = taskName;
                    gridTasks.Rows.Add(newRow);                    
                }

                RefreshDataAfterLoadFromFile(fileName);
                PutSettingsValues(settingsLoadMode);
            }
        }

        private void RefreshDataAfterLoadFromFile(string fileName)
        {
            RefreshTotalDuration();
            IsDataChanged = false;
            CurrentFileName = fileName;
            RefreshDialogTitle();
        }

        private void PutSettingsValues(bool settingsLoadMode)
        {
            if (settings[SETTINGS_KEY_LAST_FILE_NAME] == null)
            {
                settings.Add(SETTINGS_KEY_LAST_FILE_NAME, CurrentFileName);
            }
            else
            {
                if (!settingsLoadMode)
                {
                    settings[SETTINGS_KEY_LAST_FILE_NAME] = CurrentFileName;
                }
            }
        }

        private void SaveDataToFile(string fileName)
        {
            if (FileUtilities.CheckFileNameAndShowErrorIfNull(fileName))
            {
                return;
            }
            File.WriteAllText(fileName, PersistenceUtilities.GetDataStringForFile(gridTasks, TotalTasksDurationInHours));
            IsDataChanged = false;
            CurrentFileName = fileName;
            RefreshDialogTitle();

            if (settings[SETTINGS_KEY_LAST_FILE_NAME] == null)
            {
                settings.Add(SETTINGS_KEY_LAST_FILE_NAME, CurrentFileName);
            } else
            {
                settings[SETTINGS_KEY_LAST_FILE_NAME] = CurrentFileName;
            }
        }

        private void RefreshDialogTitle()
        {
            if (CurrentFileName != null && !"".Equals(CurrentFileName))
            {
                this.Text = "SuperTimeSheet - [" + CurrentFileName + "]";
            } else
            {
                this.Text = "SuperTimeSheet - [Безымянный]";
            }            
        }

        /// <summary>
        /// Method that handles 'Save As' command
        /// </summary>
        private void SaveDataAs()
        {
            string fileName = DateTime.Now.ToShortDateString() + DEFAULT_FILENAME_POSTFIX;
            saveFileDialog.FileName = fileName;
            DialogResult dlgResult = saveFileDialog.ShowDialog();

            if (dlgResult == DialogResult.OK)
            {
                string fileNameFinal = saveFileDialog.FileName;
                SaveDataToFile(fileNameFinal);
            }
        }

        private void MnuMainMenuSaveAs_Click(object sender, EventArgs e)
        {
            SaveDataAs();
        }

        private void MnuMainMenuSave_Click(object sender, EventArgs e)
        {
            if (CurrentFileName != null && !"".Equals(CurrentFileName))
            {
                SaveDataToFile(CurrentFileName);
            } else
            {
                SaveDataAs();
            }
        }

        private void ClearDataGrid()
        {
            gridTasks.Rows.Clear();
        }

        private void MnuMainMenuNewTimeSheet_Click(object sender, EventArgs e)
        {
            bool isNewTimeSheetOk = false;
            if (IsDataChanged)
            {
                DialogResult dialogResultLooseUnsavedData = MessageBox.Show("Внимание: у Вас уже есть несохраненные данные по задачам. При создании нового таймшита они будут утеряны. Действительно создать новый таймшит?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                isNewTimeSheetOk = (dialogResultLooseUnsavedData == DialogResult.Yes);
 
            }
            else
            {
                isNewTimeSheetOk = true;
            }

            if (isNewTimeSheetOk)
            {
                ClearDataGrid();
                IsDataChanged = false;
                CurrentFileName = "";
                RefreshDialogTitle();
                RefreshTotalDuration();
                settings[SETTINGS_KEY_LAST_FILE_NAME] = "";
            }
        }

        private void MnuMainMenuOpen_Click(object sender, EventArgs e)
        {
            bool isShowDialog = true;

            if (IsDataChanged)
            {
                DialogResult dialogResultOpenNewFile = MessageBox.Show("Внимание: у Вас уже есть несохраненные данные по задачам. При открытии файла текущие данные будут потеряны, если их не сохранить. Желаете загрузить файл с диска?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                isShowDialog = (dialogResultOpenNewFile == DialogResult.Yes);                
            }

            if (isShowDialog) {
                DialogResult dialogResult = openFileDialog.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    ClearDataGrid();

                    // Opened File
                    string fileName = openFileDialog.FileName;
                    ReadDataFromFile(fileName, false);
                }
            }
            


        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsDataChanged)
            {
                DialogResult dialogResultLooseUnsavedData = MessageBox.Show("Внимание: у Вас уже есть несохраненные данные по задачам. При выходе из программы они будут утеряны. Действительно выйти?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                bool isExitApp = (dialogResultLooseUnsavedData == DialogResult.Yes);

                if (!isExitApp)
                {
                    e.Cancel = true;
                }
            }
            SaveSettings();
        }

        private void BtnStartTimer_Click(object sender, EventArgs e)
        {
            if (!isTimerStarted)
            {
                if ("".Equals(txtTaskDuration.Text))
                {
                    timerForTask.Enabled = true;
                    taskStartTime = DateTime.Now;
                    txtTaskDuration.Enabled = false;
                    btnStartTimer.Text = "&Остановить таймер";
                    isTimerStarted = true;
                }
                else
                {
                    MessageBox.Show("Отсчёт времени по задаче доступен при пустом поле длительности задачи. Очистите поле и повторно запустите таймер.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                timerForTask.Enabled = false;
                txtTaskDuration.Enabled = true;
                if (radioDurationHours.Checked)
                {
                    double hours = taskDurationTimeSpan.Hours;
                    double minutes = taskDurationTimeSpan.Minutes;
                    double seconds = taskDurationTimeSpan.Seconds;

                    double dHours = hours;
                    dHours += (double)(minutes / 60);
                    dHours += (double)(seconds / 3600);

                    txtTaskDuration.Text = Convert.ToString(dHours);

                } else if (radioDurationMinutes.Checked)
                {
                    double minutes = taskDurationTimeSpan.Minutes;
                    double seconds = taskDurationTimeSpan.Seconds;

                    double dMinutes = minutes;
                    dMinutes += seconds / 60;

                    txtTaskDuration.Text = Convert.ToString(dMinutes);
                }
                
                btnStartTimer.Text = "&Запустить таймер";
                isTimerStarted = false;
            }
            

        }

        private void TimerForTask_Tick(object sender, EventArgs e)
        {
            taskDurationTimeSpan = DateTime.Now - taskStartTime;
            txtTaskDuration.Text =
                Convert.ToString(taskDurationTimeSpan.Hours) +
                " ч " +
                Convert.ToString(taskDurationTimeSpan.Minutes) + 
                " мин " + 
                Convert.ToString(taskDurationTimeSpan.Seconds) + 
                " сек";
        }

        private void BtnClearTaskDuration_Click(object sender, EventArgs e)
        {
            txtTaskDuration.Text = "";
        }

        private void GridTasks_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.C && e.Control)
            {
                DataGridViewSelectedRowCollection colSelectedRows = gridTasks.SelectedRows;
                if (colSelectedRows.Count == 1)
                {
                    gridTasks.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;

                    DataGridViewRow selectedRow = colSelectedRows[0];
                    string taskName = (string)selectedRow.Cells[1].Value;

                    DataObject dataObject = gridTasks.GetClipboardContent();

                    string currentText = dataObject.GetText();                    
                    string clipboardText = Clipboard.GetText();

                    dataObject.SetText(taskName);
                    dataObject.SetText(taskName, TextDataFormat.Text);
                    dataObject.SetText(taskName, TextDataFormat.CommaSeparatedValue);
                    dataObject.SetText(taskName, TextDataFormat.Html);
                    dataObject.SetText(taskName, TextDataFormat.Rtf);
                    dataObject.SetText(taskName, TextDataFormat.UnicodeText);
                    //dataObject.SetText(taskName, TextDataFormat.);
                    


                    Clipboard.Clear();
                    Clipboard.SetDataObject(dataObject);
                    Clipboard.SetText(taskName);
                    
                }

            }
        }

        private void CboTaskPrefix_SelectedIndexChanged(object sender, EventArgs e)
        {
            string taskPrefix = (string)cboTaskPrefix.SelectedItem;
            if (taskPrefix != null)
            {
                foreach (ProjectPrefix prefix in projectPrefixes)
                {
                    if (taskPrefix.Equals(prefix.Prefix))
                    {
                        txtPrefixDescription.Text = prefix.Description;
                    }
                }
            }
        }
    }
}
