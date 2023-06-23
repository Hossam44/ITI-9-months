using Microsoft.AspNetCore.Components;
using sharedLibrary;

namespace crudOperationForBlazor.Pages
{
    public partial class AddTrainee
    {
        public Trainee trainee { get; set; }

        public Track? track { get; set; }

        public bool Saved;

        protected override Task OnInitializedAsync()
        {
            Saved = false;
            trainee = new Trainee()
            {
                BirthDate = DateTime.Now,
                Email = "",
                Gender = GenderType.Man,
                Id = MyContext.Count++,
                IsGraduated = false,
                MobileNo = "",
                Name = "",
                TrackId = 1
            };
            return base.OnInitializedAsync();
        }

        protected void HandleValidSubmit()
        {
            MyContext.Trainees.Add(trainee);

            Saved = true;
        }

        protected void HandleInvalidSubmit()
        {
            Saved = false;
        }
    }
}
