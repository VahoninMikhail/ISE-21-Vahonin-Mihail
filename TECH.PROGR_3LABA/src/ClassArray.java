class ClassArray<T> {
	private T ITechnique;
	private ITechnique[] cells;
	private ITechnique defaultValue;

	public ClassArray(int sizes, ITechnique defVal)
	{
		defaultValue = defVal;
		cells = new ITechnique[sizes];
		for(int i = 0; i < cells.length; i++)
		{
			cells[i] = defaultValue;
		}
	}

	public ITechnique getObject(int ind)
	{
		if(ind > -1 && ind < cells.length)
		{
			return cells[ind];
		}
		return defaultValue;
	}

	public static int Plus(ClassArray<ITechnique> p, ITechnique plane)
	{
		for (int i = 0; i < p.cells.length; i++)
		{
			if (p.CheckFreePlace(i))
			{
				p.cells[i] = plane;
				return i;
			}
		}
		return -1;
	}

	public static ITechnique Minus(ClassArray<ITechnique> p, int index)
	{
		if (!p.CheckFreePlace(index))
		{
			ITechnique plane = p.cells[index];
			p.cells[index] = p.defaultValue;
			return plane;
		}
		return p.defaultValue;
	}

	private boolean CheckFreePlace(int index)
	{
		if (index < 0 || index > cells.length)
		{
			return false;
		}
		if (cells[index] == null)
		{
			return true;
		}
		if (cells[index].equals(defaultValue))
		{
			return true;
		}
		return false;
	}
}