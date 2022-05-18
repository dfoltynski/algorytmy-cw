class Sequence
{

  private int generation;
  private int value;
  private int[] vSequence;
  private int[] geneSequence;

  public int Generation { get => generation; set => generation = value; }
  public int Value { get => value; set => this.value = value; }
  public int[] VSequence { get => vSequence; set => vSequence = value; }
  public int[] GeneSequence { get => geneSequence; set => geneSequence = value; }

  public override string ToString() => $"[\n  generation={generation}, value={value},\n  vSequence=[{string.Join(",", vSequence)}],\n  geneSequence=[{string.Join(",", geneSequence)}]\n]\n";
}