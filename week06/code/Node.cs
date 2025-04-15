public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else if (value > Data)
        {
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        if (value == Data)
            return true;
        else if (value < Data)
        {

            if (Left is null)
                return false;
            else
                return Left.Contains(value);

        }
        else
        {
            if (Right is null)
                return false;
            else
                return Right.Contains(value);
        }
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        if (this is null)
            return 0;

        int leftHeight;
        int rightHeight;

        if (Left == null)
            leftHeight = 0;
        else
            leftHeight = Left.GetHeight();

        if (Right == null)
            rightHeight = 0;
        else
            rightHeight = Right.GetHeight();

        return Math.Max(leftHeight, rightHeight) + 1;
    }
}