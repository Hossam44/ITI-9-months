using Microsoft.AspNetCore.Components;
using sharedLibrary;

namespace crudOperationForBlazor.Pages
{
    public partial class EditTrainee
    {
        [Parameter]
        public int TraineeId { get; set; }

        public Trainee trainee { get; set; }

        public Trainee trainee1 { get; set; }
        public Track? track { get; set; }

        public bool Saved;

        protected override Task OnInitializedAsync()
        {
            Saved = false;

            trainee1 = MyContext.Trainees.FirstOrDefault(T => T.Id == TraineeId);

            trainee = new Trainee()
            {
                Email = trainee1.Email,
                MobileNo = trainee1.MobileNo,
                Id = trainee1.Id,
                BirthDate = trainee1.BirthDate,
                Gender = trainee1.Gender,
                IsGraduated = trainee1.IsGraduated,
                Name = trainee1.Name,
                TrackId = trainee1.TrackId
            };
            track = MyContext.Tracks.FirstOrDefault(t => t.Id == trainee?.TrackId);

            return base.OnInitializedAsync();
        }

        protected void HandleValidSubmit()
        {
            var editedTrainee = MyContext.Trainees.FirstOrDefault(T => T.Id == TraineeId);
            editedTrainee.Name = trainee.Name;
            editedTrainee.Email = trainee.Email;
            editedTrainee.BirthDate = trainee.BirthDate;
            editedTrainee.Gender = trainee.Gender;
            editedTrainee.IsGraduated = trainee.IsGraduated;
            editedTrainee.TrackId = trainee.TrackId;
            editedTrainee.MobileNo = trainee.MobileNo;

            Saved = true;
        }

        protected void HandleInvalidSubmit()
        {
            Saved = false;
        }
    }
}
