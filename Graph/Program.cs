Dictionary<string, List<string>> graph =
  new Dictionary<string, List<string>>
  {
    ["A"] = new List<string> { "B", "C" },
    ["B"] = new List<string> { "A", "D" },
    ["C"] = new List<string> { "A", "D", "E" },
    ["D"] = new List<string> { "B", "C", "E" },
    ["E"] = new List<string> { "D" }
  };






static int FindShortestDistance(
        Dictionary<string, List<string>> graph,
        string start,
        string finish)
{
  return -1;
}