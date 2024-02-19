namespace CollectionExpression_App.Usages;

public class ObjectInitialization
{
    public void Test()
    {
        var complexObject = new ComplexObject(true)
        {
            Name = "ComplexObject",
            InnerObjectList =
            [
                new ComplexObject.InnerObject { InnerName = "InnerObject1" },
                new ComplexObject.InnerObject { InnerName = "InnerObject2" }
            ],
            ComplexObject2List =
            [
                new ComplexObject2
                {
                    Name = "ComplexObject2",
                    InnerObjectList =
                    [
                        new ComplexObject2.InnerObject { InnerName = "InnerObject1" },
                        new ComplexObject2.InnerObject { InnerName = "InnerObject2" }
                    ]
                }
            ]
        };

        var complexObject2 = new ComplexObject2
        {
            Name = "ComplexObject2",
            InnerObjectList =
            [
                new ComplexObject2.InnerObject { InnerName = "InnerObject1" },
                new ComplexObject2.InnerObject { InnerName = "InnerObject2" }
            ]
        };

        List<ComplexObject> complexObjectList =
        [
            complexObject,
            new ComplexObject(true)
            {
                Name = "ComplexObject",
                InnerObjectList =
                [
                    new ComplexObject.InnerObject { InnerName = "InnerObject1" },
                    new ComplexObject.InnerObject { InnerName = "InnerObject2" }
                ],
                ComplexObject2List =
                [
                    new ComplexObject2
                    {
                        Name = "ComplexObject2",
                        InnerObjectList =
                        [
                            new ComplexObject2.InnerObject { InnerName = "InnerObject1" },
                            new ComplexObject2.InnerObject { InnerName = "InnerObject2" }
                        ]
                    }
                ]
            },

            new ComplexObject(true)
            {
                Name = "ComplexObject",
                InnerObjectList =
                [
                    new ComplexObject.InnerObject { InnerName = "InnerObject1" },
                    new ComplexObject.InnerObject { InnerName = "InnerObject2" }
                ],
                ComplexObject2List =
                [
                    complexObject2,
                    new ComplexObject2
                    {
                        Name = "ComplexObject2",
                        InnerObjectList =
                        [
                            new ComplexObject2.InnerObject { InnerName = "InnerObject1" },
                            new ComplexObject2.InnerObject { InnerName = "InnerObject2" },
                            new ComplexObject2.InnerObject { InnerName = "InnerObject3" },
                            new ComplexObject2.InnerObject
                            {
                                InnerName = "InnerObject4"
                            },
                            new ComplexObject2.InnerObject
                            {
                                InnerName = "InnerObject5"
                            }
                        ]
                    }
                ]
            }
        ];

        TestAnother([.. complexObjectList], complexObjectList[0], ((ComplexObject[]) [.. complexObjectList])[..1]);
    }

    public void Test3()
    {
        TestAnother2(1, [1, 2, 3]);
        TestAnother2(1, []);
        TestAnother3(2, "");
    }

    public void Test4()
    {
        TestAnother4([1, 2, 3]);
        TestAnother4(new List<int> { 1, 2, 3 });
    }

    private void TestAnother4(IList<int> parameterWithCoolName)
    {
        throw new NotImplementedException();
    }

    private void TestAnother3(int v, string empty)
    {
        throw new NotImplementedException();
    }

    private void TestAnother2(int v, List<int> list)
    {
        throw new NotImplementedException();
    }


    private void TestAnother(List<ComplexObject> complexObjects, ComplexObject complexObject,
                             ComplexObject[]     complexObjects1)
    {
        throw new NotImplementedException();
    }
}

public class ComplexObject(bool b)
{
    public string Name { get; set; }
    public InnerObject[] InnerObjectList { get; set; }
    public List<ComplexObject2> ComplexObject2List { get; set; }


    public class InnerObject
    {
        public string InnerName { get; set; }
    }
}

public class ComplexObject2
{
    public string Name { get; set; }
    public InnerObject[] InnerObjectList { get; set; }

    public class InnerObject
    {
        public string InnerName { get; set; }
    }
}