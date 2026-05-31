class ScriptureSelection
{
    // List of scriptures with their corresponding references.
    private List<string[]> _scriptures =
    [
        ["1 Nephi 3:7", "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."],
        ["2 Nephi 28:30", "For behold, thus saith the Lord God: I will give unto the children of men line upon line, precept upon precept, here a little and there a little; and blessed are those who hearken unto my precepts, and lend an ear unto my counsel, for they shall learn wisdom; for unto him that receiveth I will give more; and from them that shall say, We have enough, from them shall be taken away even that which they have."],
        ["Jacob 2:18", "But before ye seek for riches, seek ye for the kingdom of God."],
        ["2 Nephi 25:26", "And we talk of Christ, we rejoice in Christ, we preach of Christ, we prophesy of Christ, and we write according to our prophecies, that our children may know to what source they may look for a remission of their sins."],
        ["Alma 7:11", "And he shall go forth, suffering pains and afflictions and temptations of every kind; and this that the word might be fulfilled which saith he will take upon him the pains and the sicknesses of his people."],
        ["Mosiah 27:25", "And the Lord said unto me: Marvel not that all mankind, yea, men and women, all nations, kindreds, tongues and people, must be born again; yea, born of God, changed from their carnal and fallen state, to a state of righteousness, being redeemed of God, becoming his sons and daughters;"],
        ["Mosiah 3:19", "For the natural man is an enemy to God, and has been from the fall of Adam, and will be, forever and ever, unless he yields to the enticings of the Holy Spirit, and putteth off the natural man and becometh a saint through the atonement of Christ the Lord, and becometh as a child, submissive, meek, humble, patient, full of love, willing to submit to all things which the Lord seeth fit to inflict upon him, even as a child doth submit to his father."],
        ["Ether 12:27", "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them."],
        ["Moroni 10:32", "Yea, come unto Christ, and be perfected in him, and deny yourselves of all ungodliness; and if ye shall deny yourselves of all ungodliness, and love God with all your might, mind and strength, then is his grace sufficient for you, that by his grace ye may be perfect in Christ; and if by the grace of God ye are perfect in Christ, ye can in nowise deny the power of God."]
    ];
    // Method used to select a scripture from the array.
    public string[] RandomScripture()
    {
        Random random = new Random();
        int index = random.Next(_scriptures.Count());
        return _scriptures[index];
    }
}