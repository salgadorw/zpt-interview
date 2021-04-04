require_relative '../main.rb'
describe Main do

  it "should return 1" do
    expect(Main.new.call).to eq 1
  end
end
