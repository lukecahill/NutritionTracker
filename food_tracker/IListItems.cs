namespace food_tracker {
    public interface IListItems {
        double calories { get; set; }
        double amount { get; set; }
        double fats { get; set; }
        double saturatedFat { get; set; }
        double carbohydrates { get; set; }
        double sugar { get; set; }
        double protein { get; set; }
        double salt { get; set; }
        double fibre { get; set; }
        string name { get; set; }
        int nutritionId { get; set; }
    }
}
