<<<<<<< HEAD
﻿using System.Collections.Generic;
using Tetris.Classes.Structure;

namespace Tetris.Classes.Blocks {
  public class ZBlock : Block {
    protected override Position[][] Tiles => new Position[][] {
      new Position[] { new(0,0), new(0,1), new(1,1), new(1,2) },
      new Position[] { new(0,2), new(1,1), new(1,2), new(2,1) },
      new Position[] { new(1,0), new(1,1), new(2,1), new(2,2) },
      new Position[] { new(0,1), new(1,0), new(1,1), new(2,0) }
    };

    public override int Id => 7;
    protected override Position StartOffset => new Position(0, 3);
  }
}
=======
﻿using System.Collections.Generic;
using Tetris.Classes.Structure;

namespace Tetris.Classes.Blocks {
  public class ZBlock : Block {
    protected override Position[][] Tiles => new Position[][] {
      new Position[] { new(0,0), new(0,1), new(1,1), new(1,2) },
      new Position[] { new(0,2), new(1,1), new(1,2), new(2,1) },
      new Position[] { new(1,0), new(1,1), new(2,1), new(2,2) },
      new Position[] { new(0,1), new(1,0), new(1,1), new(2,0) }
    };

    public override int Id => 7;
    protected override Position StartOffset => new Position(0, 3);
  }
}
>>>>>>> 18821ee0da2450dcfdfee11013fd72780ef4029f
