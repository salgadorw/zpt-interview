require 'main.rb'
describe Main do

  it "#new.call should return 1" do
    expect(Main.new.call).to eq 1
  end
end
