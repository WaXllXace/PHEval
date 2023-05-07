namespace PHEval
{
    public class Eval
    {
        static ushort[] binaries_by_id =  {
            0x1,  0x1,  0x1,  0x1,
            0x2,  0x2,  0x2,  0x2,
            0x4,  0x4,  0x4,  0x4,
            0x8,  0x8,  0x8,  0x8,
            0x10,  0x10,  0x10,  0x10,
            0x20,  0x20,  0x20,  0x20,
            0x40,  0x40,  0x40,  0x40,
            0x80,  0x80,  0x80,  0x80,
            0x100,  0x100,  0x100,  0x100,
            0x200,  0x200,  0x200,  0x200,
            0x400,  0x400,  0x400,  0x400,
            0x800,  0x800,  0x800,  0x800,
            0x1000,  0x1000,  0x1000,  0x1000,
        };

        static ushort[] suitbit_by_id = {
            0x1,  0x8,  0x40,  0x200,
            0x1,  0x8,  0x40,  0x200,
            0x1,  0x8,  0x40,  0x200,
            0x1,  0x8,  0x40,  0x200,
            0x1,  0x8,  0x40,  0x200,
            0x1,  0x8,  0x40,  0x200,
            0x1,  0x8,  0x40,  0x200,
            0x1,  0x8,  0x40,  0x200,
            0x1,  0x8,  0x40,  0x200,
            0x1,  0x8,  0x40,  0x200,
            0x1,  0x8,  0x40,  0x200,
            0x1,  0x8,  0x40,  0x200,
            0x1,  0x8,  0x40,  0x200,
        };

        /*
         * Card id, ranged from 0 to 51.
         * The two least significant bits represent the suit, ranged from 0-3.
         * The rest of it represent the rank, ranged from 0-12.
         * 13 * 4 gives 52 ids.
         */
        public static int Eval5(byte a, byte b, byte c, byte d, byte e)
        {
            // Console.WriteLine("a {0} b {1} c {2} d {3} e {4}", a, b, c, d, e);
            uint suit_hash = 0;

            suit_hash += suitbit_by_id[a];
            suit_hash += suitbit_by_id[b];
            suit_hash += suitbit_by_id[c];
            suit_hash += suitbit_by_id[d];
            suit_hash += suitbit_by_id[e];

            if (DpTables.suits[suit_hash] != 0)
            {
                uint[] suit_binary = { 0, 0, 0, 0 };

                suit_binary[a & 0x3] |= binaries_by_id[a];
                suit_binary[b & 0x3] |= binaries_by_id[b];
                suit_binary[c & 0x3] |= binaries_by_id[c];
                suit_binary[d & 0x3] |= binaries_by_id[d];
                suit_binary[e & 0x3] |= binaries_by_id[e];

                return Hashtable.flush[suit_binary[DpTables.suits[suit_hash] - 1]];
            }

            byte[] quinary = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            quinary[(a >> 2)]++;
            quinary[(b >> 2)]++;
            quinary[(c >> 2)]++;
            quinary[(d >> 2)]++;
            quinary[(e >> 2)]++;

            int hash = Hash.hash_quinary(quinary, 5);

            return Hashtable5.noflush5[hash];
        }

        public static int Eval5Ids(params byte[] ids) {
            return Eval5(ids[0], ids[1], ids[2], ids[3], ids[4]);
        }

        public static int Eval5Cards(params Card[] cards)
        {
            return Eval5(cards[0].id, cards[1].id, cards[2].id, cards[3].id, cards[4].id);
        }
        
        public static int Eval5String(string s) {
            Card[] hand = Card.Cards(s);
            return Eval5(hand[0].id, hand[1].id, hand[2].id, hand[3].id, hand[4].id);
        }

        /*
        }
         * Card id, ranged from 0 to 51.
         * The two least significant bits represent the suit, ranged from 0-3.
         * The rest of it represent the rank, ranged from 0-12.
         * 13 * 4 gives 52 ids.
         */
        public static int Eval6(byte a, byte b, byte c, byte d, byte e, byte f)
        {
            int suit_hash = 0;

            suit_hash += suitbit_by_id[a];
            suit_hash += suitbit_by_id[b];
            suit_hash += suitbit_by_id[c];
            suit_hash += suitbit_by_id[d];
            suit_hash += suitbit_by_id[e];
            suit_hash += suitbit_by_id[f];

            if (DpTables.suits[suit_hash] != 0)
            {
                int[] suit_binary = { 0, 0, 0, 0 };

                suit_binary[a & 0x3] |= binaries_by_id[a];
                suit_binary[b & 0x3] |= binaries_by_id[b];
                suit_binary[c & 0x3] |= binaries_by_id[c];
                suit_binary[d & 0x3] |= binaries_by_id[d];
                suit_binary[e & 0x3] |= binaries_by_id[e];
                suit_binary[f & 0x3] |= binaries_by_id[f];

                return Hashtable.flush[suit_binary[DpTables.suits[suit_hash] - 1]];
            }

            byte[] quinary = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            quinary[(a >> 2)]++;
            quinary[(b >> 2)]++;
            quinary[(c >> 2)]++;
            quinary[(d >> 2)]++;
            quinary[(e >> 2)]++;
            quinary[(f >> 2)]++;

            int hash = Hash.hash_quinary(quinary, 6);

            return Hashtable6.noflush6[hash];
        }

        public static int Eval6Ids(params byte[] ids)
        {
            return Eval6(ids[0], ids[1], ids[2], ids[3], ids[4], ids[5]);
        }

        public static int Eval6Cards(params Card[] cards)
        {
            return Eval6(cards[0].id, cards[1].id, cards[2].id, cards[3].id, cards[4].id, cards[5].id);
        }

        public static int Eval6String(string s) {
            Card[] hand = Card.Cards(s);
            return Eval6(hand[0].id, hand[1].id, hand[2].id, hand[3].id, hand[4].id, hand[5].id);
        }

        /*
         * Card id, ranged from 0 to 51.
         * The two least significant bits represent the suit, ranged from 0-3.
         * The rest of it represent the rank, ranged from 0-12.
         * 13 * 4 gives 52 ids.
         */
        public static int Eval7(byte a, byte b, byte c, byte d, byte e, byte f, byte g)
        {
            int suit_hash = 0;

            suit_hash += suitbit_by_id[a];
            suit_hash += suitbit_by_id[b];
            suit_hash += suitbit_by_id[c];
            suit_hash += suitbit_by_id[d];
            suit_hash += suitbit_by_id[e];
            suit_hash += suitbit_by_id[f];
            suit_hash += suitbit_by_id[g];

            if (DpTables.suits[suit_hash] != 0)
            {
                int[] suit_binary = { 0, 0, 0, 0 };
                suit_binary[a & 0x3] |= binaries_by_id[a];
                suit_binary[b & 0x3] |= binaries_by_id[b];
                suit_binary[c & 0x3] |= binaries_by_id[c];
                suit_binary[d & 0x3] |= binaries_by_id[d];
                suit_binary[e & 0x3] |= binaries_by_id[e];
                suit_binary[f & 0x3] |= binaries_by_id[f];
                suit_binary[g & 0x3] |= binaries_by_id[g];

                return Hashtable.flush[suit_binary[DpTables.suits[suit_hash] - 1]];
            }

            byte[] quinary = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            quinary[(a >> 2)]++;
            quinary[(b >> 2)]++;
            quinary[(c >> 2)]++;
            quinary[(d >> 2)]++;
            quinary[(e >> 2)]++;
            quinary[(f >> 2)]++;
            quinary[(g >> 2)]++;

            int hash = Hash.hash_quinary(quinary, 7);

            return Hashtable7.noflush7[hash];
        }

        public static int Eval7Ids(params byte[] ids)
        {
            return Eval7(ids[0], ids[1], ids[2], ids[3], ids[4], ids[5], ids[6]);
        }

        public static int Eval7Cards(params Card[] cards)
        {
            return Eval7(cards[0].id, cards[1].id, cards[2].id, cards[3].id, cards[4].id, cards[5].id, cards[6].id);
        }


        public static int Eval7String(string s) {
            Card[] hand = Card.Cards(s);
            return Eval7(hand[0].id, hand[1].id, hand[2].id, hand[3].id, hand[4].id, hand[5].id, hand[6].id);
        }
        
        /*
         * Card id, ranged from 0 to 51.
         * The two least significant bits represent the suit, ranged from 0-3.
         * The rest of it represent the rank, ranged from 0-12.
         * 13 * 4 gives 52 ids.
         */
        public static int Eval8(byte a, byte b, byte c, byte d, byte e, byte f, byte g, byte h)
        {
            int suit_hash = 0;
            int value_flush = 10000;
            int value_noflush = 10000;

            suit_hash += suitbit_by_id[a];
            suit_hash += suitbit_by_id[b];
            suit_hash += suitbit_by_id[c];
            suit_hash += suitbit_by_id[d];
            suit_hash += suitbit_by_id[e];
            suit_hash += suitbit_by_id[f];
            suit_hash += suitbit_by_id[g];
            suit_hash += suitbit_by_id[h];

            if (DpTables.suits[suit_hash] != 0)
            {
                int[] suit_binary = { 0, 0, 0, 0 };
                suit_binary[a & 0x3] |= binaries_by_id[a];
                suit_binary[b & 0x3] |= binaries_by_id[b];
                suit_binary[c & 0x3] |= binaries_by_id[c];
                suit_binary[d & 0x3] |= binaries_by_id[d];
                suit_binary[e & 0x3] |= binaries_by_id[e];
                suit_binary[f & 0x3] |= binaries_by_id[f];
                suit_binary[g & 0x3] |= binaries_by_id[g];
                suit_binary[h & 0x3] |= binaries_by_id[h];

                value_flush = Hashtable.flush[suit_binary[DpTables.suits[suit_hash] - 1]];
            }

            byte[] quinary = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            quinary[(a >> 2)]++;
            quinary[(b >> 2)]++;
            quinary[(c >> 2)]++;
            quinary[(d >> 2)]++;
            quinary[(e >> 2)]++;
            quinary[(f >> 2)]++;
            quinary[(g >> 2)]++;
            quinary[(h >> 2)]++;

            int hash = Hash.hash_quinary(quinary, 8);
            
            value_noflush = Hashtable8.noflush8[hash];

            if (value_flush < value_noflush)
            {
                return value_flush;
            }
            else
            {
                return value_noflush;
            }
        }
        
        public static int Eval8Ids(params byte[] ids)
        {
            return Eval8(ids[0], ids[1], ids[2], ids[3], ids[4], ids[5], ids[6], ids[7]);
        }

        public static int Eval8Cards(params Card[] cards)
        {
            return Eval8(cards[0].id, cards[1].id, cards[2].id, cards[3].id, cards[4].id, cards[5].id, cards[6].id, cards[7].id);
        }


        public static int Eval8String(string s)
        {
            Card[] hand = Card.Cards(s);
            return Eval8(hand[0].id, hand[1].id, hand[2].id, hand[3].id, hand[4].id, hand[5].id, hand[6].id, hand[7].id);
        }

        public static int Eval9(byte a, byte b, byte c, byte d, byte e, byte f, byte g, byte h, byte i)
        {
            int value_flush = 10000;
            int value_noflush = 10000;
            int[] suit_counter = { 0, 0, 0, 0 };

            suit_counter[a & 0x3]++;
            suit_counter[b & 0x3]++;
            suit_counter[c & 0x3]++;
            suit_counter[d & 0x3]++;
            suit_counter[e & 0x3]++;
            suit_counter[f & 0x3]++;
            suit_counter[g & 0x3]++;
            suit_counter[h & 0x3]++;
            suit_counter[i & 0x3]++;

            for (int l = 0; l < 4; l++)
            {
                if (suit_counter[l] >= 5)
                {
                    int[] suit_binary = {0, 0, 0, 0};
                    suit_binary[a & 0x3] |= binaries_by_id[a];
                    suit_binary[b & 0x3] |= binaries_by_id[b];
                    suit_binary[c & 0x3] |= binaries_by_id[c];
                    suit_binary[d & 0x3] |= binaries_by_id[d];
                    suit_binary[e & 0x3] |= binaries_by_id[e];
                    suit_binary[f & 0x3] |= binaries_by_id[f];
                    suit_binary[g & 0x3] |= binaries_by_id[g];
                    suit_binary[h & 0x3] |= binaries_by_id[h];
                    suit_binary[i & 0x3] |= binaries_by_id[i];
                    
                    value_flush = Hashtable.flush[suit_binary[l]];

                    break;
                }
            }

            byte[] quinary = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            quinary[(a >> 2)]++;
            quinary[(b >> 2)]++;
            quinary[(c >> 2)]++;
            quinary[(d >> 2)]++;
            quinary[(e >> 2)]++;
            quinary[(f >> 2)]++;
            quinary[(g >> 2)]++;
            quinary[(h >> 2)]++;
            quinary[(i >> 2)]++;

            int hash = Hash.hash_quinary(quinary, 9);
            
            value_noflush = Hashtable9.noflush9[hash];

            if (value_flush < value_noflush)
            {
                return value_flush;
            }
            else
            {
                return value_noflush;
            }
        }
        
        public static int Eval9Ids(params byte[] ids)
        {
            return Eval9(ids[0], ids[1], ids[2], ids[3], ids[4], ids[5], ids[6], ids[7], ids[8]);
        }

        public static int Eval9Cards(params Card[] cards)
        {
            return Eval9(cards[0].id, cards[1].id, cards[2].id, cards[3].id, cards[4].id, cards[5].id, cards[6].id, cards[7].id, cards[8].id);
        }
        
        public static int Eval9String(string s)
        {
            Card[] hand = Card.Cards(s);
            return Eval9(hand[0].id, hand[1].id, hand[2].id, hand[3].id, hand[4].id, hand[5].id, hand[6].id, hand[7].id, hand[8].id);
        }
    }
}