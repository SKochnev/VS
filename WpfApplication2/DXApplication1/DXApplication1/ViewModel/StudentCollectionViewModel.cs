using DevExpress.Mvvm.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1
{
    class StudentCollectionViewModel
    {
        public StudentCollectionViewModel()
        {
            Grouplist.Add(new Group { Name = "BIS" });
            Grouplist.Add(new Group { Name = "BPI" });
            Grouplist.Add(new Group { Name = "BIK" });
            
        }



        [BindableProperty]
        public virtual ObservableCollection<SudentModel> StudentList { get; set; }

        [BindableProperty]
        public virtual ObservableCollection<ExpilledStudenModel> ExpilledStudentList { get; set; }

        public virtual ObservableCollection<Group> Grouplist { get; set; }
        [BindableProperty]
        public virtual SudentModel CurrentStudent { get; set; }

        [Command]
        public void NewStudent(SudentModel stud)
        {
            StudentList.Add(new SudentModel() { FIO = "Pasha", Phone = "*99999999" });
        }

        [Command]
        public void EditSudent(SudentModel stud)
        {
            StudentList.Single(w => w.Id == stud.Id).IsRemoved = true;
        }

        [Command]
        public void DeleteSudent(SudentModel stud)
        {
            StudentList.Single(w => w.Id == stud.Id).IsRemoved = true;
        }

        [Command]
        public void StudentOnExpulsion(SudentModel stud)
        {
            ExpilledStudentList.Add(new ExpilledStudenModel
            {
                Id = stud.Id,
                IsRemoved = stud.IsRemoved,
                FIO = stud.FIO,
                Phone = stud.Phone,
            });
            StudentList.Remove(stud);
        } 

    }

    
}
