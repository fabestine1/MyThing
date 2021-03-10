/*
//<SUMMARY>
//This command reads an NFC card and returns its UID
*/
void ReadNfcUid()
{
  if (doChipScan)
  {
    static int count = 0;
    count++;

    if (nfc.tagPresent())
    {
      NfcTag tag = nfc.read();
      String UID = tag.getUidString();
      RETURNNFCTAG(UID);

      doChipScan = false;
      count = 0;
    }
    if (count > 10)
    {
      doChipScan = false;
      count = 0;
    }
  }
}
