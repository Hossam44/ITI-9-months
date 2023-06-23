using Microsoft.AspNetCore.Components;
using sharedLibrary;

namespace crudOperationForBlazor.Pages
{
    public partial class TraineeDetails
    {
        [Parameter]
        public int TraineeId { get; set; }

        public Trainee? trainee { get; set; }
        public Track? track { get; set; }

        protected override Task OnInitializedAsync()
        {
            trainee = MyContext.Trainees.FirstOrDefault(T => T.Id == TraineeId);
            track = MyContext.Tracks.FirstOrDefault(t => t.Id == trainee?.TrackId);
            return base.OnInitializedAsync();
        }
    }
}
