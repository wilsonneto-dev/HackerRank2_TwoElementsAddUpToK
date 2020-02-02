const TwoElementsAddUpToK = require("./TwoElementsAddUpToK.js");

test("array with 1, 2, 3 and k = 15", () => {
  expect(TwoElementsAddUpToK.verify([1, 2, 3], 15)).toBe(false);
});

test("array with 1, 2, 3 and k = 5", () => {
  expect(TwoElementsAddUpToK.verify([1, 2, 3], 5)).toBe(true);
});
