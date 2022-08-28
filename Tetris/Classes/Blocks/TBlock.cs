<<<<<<< HEAD
﻿using System.Collections.Generic;
using Tetris.Classes.Structure;

namespace Tetris.Classes.Blocks {
  public class TBlock : Block {
    protected override Position[][] Tiles => new Position[][] {
      new Position[] { new(0,1), new(1,0), new(1,1), new(1,2) },
      new Position[] { new(0,1), new(1,1), new(1,2), new(2,1) },
      new Position[] { new(1,0), new(1,1), new(1,2), new(2,1) },
      new Position[] { new(0,1), new(1,0), new(1,1), new(2,1) }
    };

    public override int Id => 6;
    protected override Position StartOffset => new Position(0, 3);
  }
}
=======
﻿using System.Collections.Generic;
using Tetris.Classes.Structure;

namespace Tetris.Classes.Blocks {
  public class TBlock : Block {
    protected override Position[][] Tiles => new Position[][] {
      new Position[] { new(0,1), new(1,0), new(1,1), new(1,2) },
      new Position[] { new(0,1), new(1,1), new(1,2), new(2,1) },
      new Position[] { new(1,0), new(1,1), new(1,2), new(2,1) },
      new Position[] { new(0,1), new(1,0), new(1,1), new(2,1) }
    };

    public override int Id => 6;
    protected override Position StartOffset => new Position(0, 3);
  }
}
>>>>>>> 18821ee0da2450dcfdfee11013fd72780ef4029f
