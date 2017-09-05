using food_tracker.Repository;
using System;
using System.Windows.Forms;

namespace food_tracker {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new trackerForm(new NutritionRepository(), new DayRepository()));
		}
	}
}
