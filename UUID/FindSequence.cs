namespace UUID
{
    public class FindSequence : IFindSequence
    {
        public string FindMaxSequence(string data)
        {
            var dataItems = data.Split(" ").Select(d => Convert.ToInt32(d)).ToList();
            var sequence = 0;
            var result = new Dictionary<int, List<int>>();

            for (int i = 1; i < dataItems.Count; i++)
            {
                var diff = dataItems[i - 1] - dataItems[i];

                if (diff < 0)
                {
                    if (result.ContainsKey(sequence)) result[sequence].Add(dataItems[i]);
                    else result.Add(sequence, new List<int> { dataItems[i - 1], dataItems[i] });
                }
                else sequence++;
            }

            var finalResult = result.Select((d, index) => new { Index = index, Key = d.Key, Values = d.Value, Count = d.Value.Count })
                .OrderByDescending(d => d.Count)
                .ThenBy(d => d.Index)
                .First();

            return string.Join(" ", finalResult.Values);
        }
    }
}