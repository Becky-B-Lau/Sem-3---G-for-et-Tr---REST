namespace REST_API_GåForEtTræ.Model
{
    public class Steps
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public int counter_tree { get; set; }
        public int phase {  get; set; }
        public int steps { get; set; }

        public Steps(int id, string date, int counter_tree, int phase, int steps)
        {
            Id = id;
            Date = date;
            this.counter_tree = counter_tree;
            this.phase = phase;
            this.steps = steps;
        }

        public Steps()
        {
        }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Date)}={Date}, {nameof(counter_tree)}={counter_tree.ToString()}, {nameof(phase)}={phase.ToString()}, {nameof(steps)}={steps.ToString()}}}";
        }
    }
}
