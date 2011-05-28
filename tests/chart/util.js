function ViewFactoryStub() {
    var factory = this,
        log = factory.log = { };

    log.rect = [];
}

ViewFactoryStub.prototype = {
    rect: function(box, style) {
        this.log.rect.push({
            x1: box.x1,
            y1: box.y1,
            x2: box.x2,
            y2: box.y2,
            style: style
        });
    }
};

function sameBox(a, b) {
    same([a.x1, a.y1, a.x2, a.y2], [b.x1, b.y1, b.x2, b.y2]);
}
