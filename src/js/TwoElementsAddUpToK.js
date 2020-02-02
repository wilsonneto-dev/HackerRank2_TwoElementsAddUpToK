module.exports = {
  verify: (numbers, k) => {
    let finded = false;
    numbers.forEach(num => {
      if (num < k) {
        const perfectMatch = k - num;
        if (numbers.find(n => n === perfectMatch)) {
          finded = true;
        }
      }
    });
    return finded;
  }
};
